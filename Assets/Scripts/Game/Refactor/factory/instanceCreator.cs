using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class instanceCreator : ObstacleSpawnerBase
{
    // Start is called before the first frame update

   /* [SerializeField]
    private PoolableObject obstacleLowPool;

    [SerializeField]
    private PoolableObject obstacleMidPool;
   */
    [SerializeField]
    private PoolableObject obstaclePools;

    private List<PoolableObject> objects;

    [SerializeField]
    private GameObject[] prefabs;



    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            objects.Add(obstaclePools);

        }
        SpawnObject(obstaclePools);


    }

    // Update is called once per frame
    void Update()
    {



    }
    void recycle(PoolableObject target)
    {
        if (target != null)
        {
            objects.Add(target);
            Destroy(target);
        }
    }


    protected override void SpawnObject(PoolableObject target)
    {
        if (target = null)
        {
            Instantiate(target, new Vector2(Random.Range(MinX, MaxX), YPos), // Sets the position to instantiate in 2D (Z is always 0)
            Quaternion.identity);
        }

    }
}
