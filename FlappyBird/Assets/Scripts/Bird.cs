using System;
using UnityEngine;

[RequireComponent(typeof(BirdMover))]
[RequireComponent(typeof(BirdCollisionHandler))]
public class Bird : MonoBehaviour
{
    private BirdMover _birdMover;    
    private BirdCollisionHandler _handler;

    public event Action GameOver;

    private void Awake()
    {        
        _handler = GetComponent<BirdCollisionHandler>();
        _birdMover = GetComponent<BirdMover>();
    }

    private void OnEnable()
    {
        _handler.CollisionDetected += ProcessCollision;
    }

    private void OnDisable()
    {
        _handler.CollisionDetected -= ProcessCollision;
    }

    private void ProcessCollision(IInteractable interactable)
    {
        switch (interactable)
        {
            case Ground:
                GameOver?.Invoke();
                break;
            case Egg:
                GameOver?.Invoke();
                break;
            default:
                break;
        }           
    }

    public void Reset()
    {       
        _birdMover.Reset();
    }
}