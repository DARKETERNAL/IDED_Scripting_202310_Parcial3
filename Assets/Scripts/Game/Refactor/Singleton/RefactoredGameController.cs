using UnityEngine;
public sealed class RefactoredGameController : GameControllerBase
{


    public static RefactoredGameController Instance;

    protected override PlayerControllerBase PlayerController => RefactoredPlayerController.Instance;

    protected override UIManagerBase UiManager => RefactoredUIManager.Instance;

    protected override ObstacleSpawnerBase Spawner => RefactoredObstacleSpawner.Instance;


    protected override void OnScoreChanged(int scoreAdd)
    {
        PlayerController?.SendMessage("UpdateScore", scoreAdd);
        UiManager?.SendMessage("UpdateScoreLabel");
    }
    private static GameController instance;

  



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