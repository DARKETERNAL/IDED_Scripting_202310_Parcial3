using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class midObstaclePool :  PoolBase<midObstaclePool>, IPoolable
{
    public void Free()
    {
        throw new System.NotImplementedException();
    }

    public void New()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        PopulatePool();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnDestroy() { }
    public override void RecycleInstance(GameObject instance)
    {

    }
  
}
