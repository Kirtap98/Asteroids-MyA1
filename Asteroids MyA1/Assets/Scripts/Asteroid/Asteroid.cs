using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour,ITakeDamage
{
    Rigidbody2D _rb2D;

    public float lifeAsteroid;
    float force;
    Vector2 _dir;

    // Start is called before the first frame update
    void Start()
    {
        _dir = new Vector2( Random.Range(0, 1), Random.Range(0, 1));
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void TakeDamage(float _damage)
    {
        force = _damage;
        lifeAsteroid -= _damage;
    }

    void Move()
    {
        _rb2D.velocity = _dir * 1;
    }

    public void Force()
    {
        _rb2D.AddForce( -_dir * force, ForceMode2D.Impulse);
    }
}
