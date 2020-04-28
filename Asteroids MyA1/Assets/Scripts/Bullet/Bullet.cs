using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damageBullet;
    public float speedBullet;
    Rigidbody2D _rb2D;

    public virtual void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    public virtual void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        _rb2D.velocity = transform.up * speedBullet;
    }
}
