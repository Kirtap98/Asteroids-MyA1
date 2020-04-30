using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damageBullet;
    public float speedBullet;
    public float timeLife;
    public bool _return = false;
    Rigidbody2D _rb2D;

    public virtual void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        StartCoroutine(Reset());
    }

    public virtual void Update()
    {
        Debug.Log(_return);

        if(_return==true)
        {
            StopCoroutine(Reset());
            _return = false;
        }
    }

    public virtual void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.position+=transform.up*speedBullet*Time.deltaTime;
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(timeLife);
        PoolBullet.Instance.Retur(gameObject);
        _return = true;

    }
}
