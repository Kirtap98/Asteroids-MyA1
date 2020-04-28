using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonTorpedoBullet : Bullet
{
    public float explotionArea;

    float _force;

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
        var _col = gameObject.GetComponent<ITakeDamage>();

        if (_col != null)
        {
            _return = true;

            RangeExplotion();

            _col.TakeDamage(_force);

            PoolBullet.Instance.Retur(gameObject);
        }
    }

    void RangeExplotion()
    {
        Collider2D[] asteroid = Physics2D.OverlapCircleAll(transform.position, explotionArea);

        foreach (var _objets in asteroid)
        {
            if (_objets.gameObject == gameObject) continue;

            _force = damageBullet * ((_objets.transform.position - transform.position).magnitude / explotionArea);
        }
    }
}
