using UnityEngine;
public sealed class RefactoredGameController : GameControllerBase
{


    public static RefactoredGameController Instance;

    protected override PlayerControllerBase PlayerController => RefactoredPlayerController.Instance;

    protected override UIManagerBase UiManager => RefactoredUIManager.Instance;

    protected override ObstacleSpawnerBase Spawner => RefactoredObstacleSpawner.Instance;


    protected override void OnScoreChanged(int hp)
    {
       
        UiManager?.SendMessage("UpdateScoreLabel");
        PlayerController?.SendMessage("UpdateScore", hp);
    }
    private static GameController instance;

  



    protected override void SetGameOver()
    {
        UiManager?.SendMessage("OnGameOver");
        PlayerController?.SendMessage("OnGameOver");
        Spawner?.SendMessage("OnGameOver");
        base.SetGameOver();

    }

        

    
    private void GameController()
    {

    }

}