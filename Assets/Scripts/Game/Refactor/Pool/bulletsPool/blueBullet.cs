using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class blueBullet : PoolBase<blueBullet>, IPoolable
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public override void RecycleInstance(GameObject instance)
    {

    }


    public void PrepareForRetrieve()
    {
        throw new System.NotImplementedException();
    }

    public void PrepareForRecycle(Transform parent)
    {
        throw new System.NotImplementedException();
    }
}
