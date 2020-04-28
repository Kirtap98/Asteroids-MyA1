using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour,ITakeDamage
{
    Rigidbody2D _rb2D;

    public float lifeAsteroid;

    // Start is called before the first frame update
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
    }

    public void TakeDamage(float _damage)
    {
        
    }
}
