using TMPro.EditorUtilities;
using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{


    [SerializeField]
    private PoolBase<PoolableObject> obstacleMidPool;

    [SerializeField]
    private PoolBase<PoolableObject> obstacleHardPool;



    [SerializeField]
    private PoolBase<PoolableObject> obstacleLowPool; //poolable objects




    [SerializeField]
    private GameObject[] obstaclePrefabs ;
    private static RefactoredObstacleSpawner instance;

    private PoolBase<PoolableObject> obstaclePool; //obstacle pool

    public static RefactoredObstacleSpawner Instance => instance;
    void Start()
    {
        //obstaclePool = gameObject.AddComponent<obstacleLowPool>(); 
    }

    protected override void SpawnObject()
    {
        Instantiate(
            obstaclePrefabs[ObjectIndex],                // Retrieves the prefab to instantiate
            new Vector2(Random.Range(MinX, MaxX), YPos), // Sets the position to instantiate in 2D (Z is always 0)
            Quaternion.identity);
    }

    protected void addNewInstanceToPool()
    {

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