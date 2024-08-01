using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Pool<Enemy>
{    
    public override Enemy GetObject(Vector2 direction)
    {
        if (_pool.Count == 0)
        {
            var enemy = Instantiate(_prefab);
            enemy.transform.parent = _container;

            return enemy;
        }

        return _pool.Dequeue();
    }    
}