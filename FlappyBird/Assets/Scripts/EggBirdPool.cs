using System.Collections.Generic;
using UnityEngine;

public class EggBirdPool : Pool
{   
    [SerializeField] private EggBird _prefab;

    private Queue<EggBird> _eggPool = new Queue<EggBird>();

    public IEnumerable<EggBird> PooledEggs => _eggPool;

    public EggBird GetObject(Vector2 direction)
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

    public void PutObject(EggBird egg)
    {
        _eggPool.Enqueue(egg);
        egg.gameObject.SetActive(false);
    }

    public override void Reset()
    {
        _eggPool.Clear();
    }
}
