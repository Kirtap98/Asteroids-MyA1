using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaserBullet : Bullet
{
    public override void Start()
    {
        base.Start();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
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
