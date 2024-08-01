using UnityEngine;

public class Egg : MonoBehaviour, IInteractable
{
    private float _speed = 5f;
   
    private Vector2 _movement;
    
    public void DirectionChange(Vector2 direction)
    {
        _movement = direction;                 
    }    

    private void Update()
    {
        transform.Translate(_movement * _speed * Time.deltaTime);        
    }    
}
