using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    [SerializeField] private float _delay;    
    [SerializeField] private EggPool _eggsPool;

    private Vector2 _direction = Vector2.left;

    private void OnEnable()
    {
        StartCoroutine(GenerateEggs());
    }

    private IEnumerator GenerateEggs()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            Spawn();
            yield return wait;
        }
    }

    private void Spawn()
    {
        Vector3 spawnPoint = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);

        var egg = _eggsPool.GetObject(_direction);
        egg.gameObject.SetActive(true);
        egg.transform.position = spawnPoint;
    }
}
