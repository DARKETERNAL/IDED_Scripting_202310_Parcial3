using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoolableObject : MonoBehaviour, IPoolable
    

{

    public void PrepareForRecycle(Transform parent)
    {
        throw new System.NotImplementedException();
    }

    public void PrepareForRetrieve()
    {
        throw new System.NotImplementedException();
    }


    public void onDestroy(PoolableObject target, instanceCreator instanceCreator) {
        instanceCreator.SendMessage("SpawnObject", target);
    
    }

}
