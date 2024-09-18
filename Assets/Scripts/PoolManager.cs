using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance { get; private set; }

    private List<GameObject> pooledObjects;

    [SerializeField] private GameObject prefabToPool;
    [SerializeField] private Transform pooledObjectsParent;
    [SerializeField] private int poolSize;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();

        GameObject tmp;

        for (int i = 0; i < poolSize; i++)
        {
            tmp = Instantiate(prefabToPool, pooledObjectsParent);

            tmp.SetActive(false);

            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < poolSize; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }

        return null;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
