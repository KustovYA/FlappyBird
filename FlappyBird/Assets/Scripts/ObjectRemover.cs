using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    [SerializeField] private ObjectPool _pool;
    [SerializeField] private EggPool _eggPool;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("¬раг столкнулс€");

        if (other.TryGetComponent(out Enemy enemy))
        {
            _pool.PutObject(enemy);
            Debug.Log("¬рага отправил в пул");
        }
        else if (other.TryGetComponent(out Egg egg))
        {
            _eggPool.PutObject(egg);
            Debug.Log("яйцо отправил в пул");
        }
    }
}
