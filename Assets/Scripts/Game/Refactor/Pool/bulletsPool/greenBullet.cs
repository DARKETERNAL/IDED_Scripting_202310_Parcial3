using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class greenBullet : PoolBase<greenBullet>, IPoolable
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
