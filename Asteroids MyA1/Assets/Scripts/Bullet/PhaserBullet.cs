using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaserBullet : MonoBehaviour
{
    public float damageBullet;
    public float speedBullet;
    Rigidbody2D _rb2D;

    private void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        _rb2D.velocity = transform.up * speedBullet;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var _col = collision.gameObject.GetComponent<ITakeDamage>();

        if(_col != null)
        {
            _col.TakeDamage(damageBullet);
        }
    }
}
