using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    [SerializeField] private ObjectPool _pool;
    [SerializeField] private EggPool _eggPool;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("���� ����������");

        if (other.TryGetComponent(out Enemy enemy))
        {
            _pool.PutObject(enemy);
            Debug.Log("����� �������� � ���");
        }
        else if (other.TryGetComponent(out Egg egg))
        {
            _eggPool.PutObject(egg);
            Debug.Log("���� �������� � ���");
        }
    }
}
