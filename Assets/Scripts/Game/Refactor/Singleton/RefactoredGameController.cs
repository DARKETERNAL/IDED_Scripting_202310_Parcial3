using UnityEngine;
public sealed class RefactoredGameController : GameControllerBase
{
    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override UIManagerBase UiManager => throw new System.NotImplementedException();

    protected override ObstacleSpawnerBase Spawner => throw new System.NotImplementedException();

    protected override void OnScoreChanged(int scoreAdd)
    {
        PlayerController?.SendMessage("UpdateScore", scoreAdd);
        UiManager?.SendMessage("UpdateScoreLabel");
    }
    private static GameController instance;

  

    public static GameController Instance
    {
        get
        {
            // Si la instancia no existe, la creamos
            if (instance == null)
            {
                instance = new GameController();
            }
            return instance;
        }
    }
    [SerializeField]
    private UIManager uiManager;

    [SerializeField]
    private PlayerController playerController;

    [SerializeField]
    private ObstacleSpawner obstacleSpawner;




    protected override void SetGameOver()
    {
        UiManager?.SendMessage("OnGameOver");
        PlayerController?.SendMessage("OnGameOver");
        Spawner?.SendMessage("OnGameOver");
        base.SetGameOver();
    }

    // Constructor privado para prevenir la creación de instancias externas
    private void GameController()
    {

    }

}