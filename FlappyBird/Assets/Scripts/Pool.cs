using System.Collections.Generic;
using UnityEngine;

public abstract class Pool<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T _prefab;
    [SerializeField] protected Transform _container;

    protected Queue<T> _pool = new Queue<T>();
    
    public IEnumerable<T> PooledObjects => _pool;

    public abstract T GetObject(Vector2 direction);

    public void PutObject(T pooledObject)
    {
        _pool.Enqueue(pooledObject);
        pooledObject.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _pool.Clear();
    }
}
