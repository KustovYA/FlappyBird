using UnityEngine;

public class EggPool : Pool<Egg>
{      
    public override Egg GetObject(Vector2 direction)
    {
        if (_pool.Count == 0)
        {
            var egg = Instantiate(_prefab);
            egg.transform.parent = _container;  
            egg.DirectionChange(direction);            

            return egg;
        }

        return _pool.Dequeue();
    }   
}
