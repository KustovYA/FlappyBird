using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPool : MonoBehaviour
{
    [SerializeField] private Transform _container;   
    [SerializeField] private Egg _prefab;
   
    private Queue<Egg> _eggPool;

    public IEnumerable<Egg> PooledEggs => _eggPool;

    private void Awake()
    {
        _eggPool = new Queue<Egg>();
    }

    public Egg GetObject(Vector2 direction)
    {
        if (_eggPool.Count == 0)
        {
            var egg = Instantiate(_prefab);
            egg.transform.parent = _container;  
            egg.DirectionChange(direction);
            

            return egg;
        }

        return _eggPool.Dequeue();
    }

    public void PutObject(Egg egg)
    {
        _eggPool.Enqueue(egg);
        egg.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _eggPool.Clear();
    }
}
