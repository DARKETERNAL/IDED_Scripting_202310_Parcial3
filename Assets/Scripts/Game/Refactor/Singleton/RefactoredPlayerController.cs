using UnityEngine;
public class RefactoredPlayerController : PlayerControllerBase
{
    protected override bool NoSelectedBullet => throw new System.NotImplementedException();
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

    protected override void SelectBullet(int index)
    {
        selectedBullet = bulletPrefabs[GameUtils.GetClampedValue(index, bulletPrefabs.Length)];
        uiManager.SendMessage("EnableIcon", index);
    }

}