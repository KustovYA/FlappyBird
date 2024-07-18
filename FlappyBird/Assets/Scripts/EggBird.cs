using UnityEngine;

public class EggBird : MonoBehaviour, IInteractable
{
    private float _speed = 5f;

    private Vector2 movement;

    public void DirectionChange(Vector2 direction)
    {
        movement = direction;
    }

    private void Update()
    {
        transform.Translate(movement * _speed * Time.deltaTime);
    }
}
