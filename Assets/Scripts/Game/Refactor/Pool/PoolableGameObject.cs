using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoolableGameObject : MonoBehaviour, IPool
{

    public void RecycleInstance(GameObject instance)
    {
        throw new System.NotImplementedException();
    }

    public GameObject RetrieveInstance()
    {
        throw new System.NotImplementedException();
    }
}
