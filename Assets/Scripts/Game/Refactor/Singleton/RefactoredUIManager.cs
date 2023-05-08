using UnityEngine;
public class RefactoredUIManager : UIManagerBase
{
    protected override PlayerControllerBase PlayerController => playerController;

    protected override GameControllerBase GameController => gameController;

    private static RefactoredUIManager instance;

    public static RefactoredUIManager Instance => instance ??= FindObjectOfType<RefactoredUIManager>();

    [SerializeField]
    private PlayerControllerBase playerController;

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