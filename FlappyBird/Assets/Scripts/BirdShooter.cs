using UnityEngine;

public class BirdShooter : MonoBehaviour
{    
    [SerializeField] private EggBirdPool _eggsPool;
    [SerializeField] private BirdMover _birdMover;
    
    private void Update()
    {        
        Quaternion rotation = _birdMover.transform.rotation;
        Vector2 direction = new Vector2(1f, 0f);
        Vector3 direction3D = new Vector3(direction.x, direction.y, 0f);
        Vector3 rotatedDirection = rotation * direction3D;

        Vector2 rotatedDirection2D = new Vector2(rotatedDirection.x, rotatedDirection.y);

        if (Input.GetKeyDown(KeyCode.D))
        {
            Shoot(rotatedDirection2D);
        }        
    }   

    private void Shoot(Vector2 rotatedDirection2D)
    {
        Vector3 spawnPoint = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);

        var egg = _eggsPool.GetObject(rotatedDirection2D);
        egg.gameObject.SetActive(true);
        egg.transform.position = spawnPoint;
    }
}
