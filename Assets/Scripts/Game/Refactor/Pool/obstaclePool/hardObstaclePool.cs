using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hardObstaclePool : PoolBase<hardObstaclePool>, IPoolable
{
    public void Free()
    {
        throw new System.NotImplementedException();
    }

    public void New()
    {
        throw new System.NotImplementedException();
    }

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public override void RecycleInstance(GameObject instance)
    {

    }
}
