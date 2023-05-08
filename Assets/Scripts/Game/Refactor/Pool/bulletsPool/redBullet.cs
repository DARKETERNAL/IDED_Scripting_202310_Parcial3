using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class redBullet : PoolBase<redBullet>, IPoolable
{
    public void PrepareForRetrieve()
    {
        throw new System.NotImplementedException();
    }

    public void PrepareForRecycle(Transform parent)
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
