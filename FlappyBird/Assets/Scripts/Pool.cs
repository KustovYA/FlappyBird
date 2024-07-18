using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pool : MonoBehaviour
{
    [SerializeField] protected Transform _container;        

    public abstract void Reset();    
}
