using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damageBullet;
    public float speedBullet;
    public float timeLife;
    protected bool _return = false;
    Rigidbody2D _rb2D;

    public virtual void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        StartCoroutine(Reset());
    }

    public virtual void Update()
    {
        Debug.Log(_return);

        if(_return)
        {
            StopCoroutine(Reset());
        }
    }

    public virtual void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        _rb2D.velocity = transform.up * speedBullet;
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(timeLife);
        PoolBullet.Instance.Retur(gameObject);
    }
}
