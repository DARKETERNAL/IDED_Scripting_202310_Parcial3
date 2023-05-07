using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{
    [SerializeField]
    private PoolBase<PoolableObject> obstacleLowPool;

    [SerializeField]
    private PoolBase<PoolableObject> obstacleMidPool;

    [SerializeField]
    private PoolBase<PoolableObject> obstacleHardPool;

    [SerializeField]
    private GameObject[] obstaclePrefabs;
    private static RefactoredObstacleSpawner instance;
    private PoolBase<lowObstaclePool> obstaclePool;

    public static RefactoredObstacleSpawner Instance => instance;
    void Start()
    {
        obstaclePool = gameObject.AddComponent<lowObstaclePool>(); 
    }

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