using UnityEngine;
public class RefactoredPlayerController : PlayerControllerBase
{
    protected override bool NoSelectedBullet => throw new System.NotImplementedException(); //bool?
    public static RefactoredPlayerController Instance { get; private set; }
    [SerializeField]
    private UIManager uiManager;

    protected Rigidbody selectedBullet;


    protected override void Shoot()
    {
        Instantiate(selectedBullet, spawnPos.position, spawnPos.rotation)
                            .AddForce(transform.forward * shootForce, ForceMode.Force);
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void OnScoreChangedEvent(int scoreAdd)
    {
        UpdateScore(scoreAdd);

    }
    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    protected override void SelectBullet(int index)  //esto es lo que tengo que volver que use los pools
    {
        selectedBullet = bulletPrefabs[GameUtils.GetClampedValue(index, bulletPrefabs.Length)];
        uiManager.SendMessage("EnableIcon", index);
    }

    private void ProcessShooting() //tiene las entradas por teclado
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Fire
            if (NoSelectedBullet)
            {
                SelectBullet(0);
            }

            if (spawnPos != null)
            {
                Shoot();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectBullet(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectBullet(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectBullet(2);
        }
    }

}