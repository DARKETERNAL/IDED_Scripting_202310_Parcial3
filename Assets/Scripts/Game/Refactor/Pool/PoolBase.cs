using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PoolBase<T> : MonoBehaviour, IPool //se editó
    where T : IPoolable
{

    private static PoolBase<T> instance;

    public static PoolBase<T> Instance { get => instance; protected set => instance = value; }


    [SerializeField]
    private int count = 0;

    [SerializeField]
    private GameObject basePrefab;

    private List<GameObject> instances = new List<GameObject>();

    public abstract void RecycleInstance(GameObject instance);
    

    public GameObject RetrieveInstance()
    {
        throw new System.NotImplementedException();
    }

    public void PopulatePool()
    {
        for (int i = 0; i < count; i++)
        {
            instances.Add(Instantiate(basePrefab, transform.position, Quaternion.identity));
        }
    }
}