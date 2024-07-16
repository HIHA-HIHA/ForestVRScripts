using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolForDestroy : MonoBehaviour
{

    private List<GameObject> pool = new List<GameObject>(); 

    public static PoolForDestroy Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void AddObject(GameObject gameObjectForDestroy)
    {
        pool.Add(gameObjectForDestroy);
    }

    public void DestroyAll()
    {
        pool.ForEach(@object =>
        {
            Destroy(@object);
        });
        pool.Clear();
    }

    public void RemoveObject(GameObject gameObject)
    {
        pool.Remove(gameObject);
    }
}
