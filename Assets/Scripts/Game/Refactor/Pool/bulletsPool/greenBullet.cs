using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class greenBullet : PoolBase<greenBullet>, IPoolable
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void RecycleInstance(GameObject instance)
    {

    }

    public void New()
    {
        throw new System.NotImplementedException();
    }

    public void Free()
    {
        throw new System.NotImplementedException();
    }
}
