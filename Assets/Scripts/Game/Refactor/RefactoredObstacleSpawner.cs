using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{
    [SerializeField]
    private PoolBase obstacleLowPool;

    [SerializeField]
    private PoolBase obstacleMidPool;

    [SerializeField]
    private PoolBase obstacleHardPool;

    [SerializeField]
    private GameObject[] obstaclePrefabs;
    private static RefactoredObstacleSpawner instance;

    public static RefactoredObstacleSpawner Instance => instance;

    protected override void SpawnObject()
    {
        throw new System.NotImplementedException();
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    private int ObjectIndex
    {
        get
        {
            int result = 0;

            if (obstaclePrefabs.Length > 1)
            {
                result = Random.Range(result, obstaclePrefabs.Length);
            }

            return result;
        }
    }

}