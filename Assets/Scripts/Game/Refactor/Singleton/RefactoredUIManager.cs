using UnityEngine;
public class RefactoredUIManager : UIManagerBase
{
    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override GameControllerBase GameController => throw new System.NotImplementedException();

    private static RefactoredUIManager instance;

    public static RefactoredUIManager Instance => instance ??= FindObjectOfType<RefactoredUIManager>();

    [SerializeField]
    private PlayerController playerController;

    [SerializeField]
    private GameControllerBase gameController;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}