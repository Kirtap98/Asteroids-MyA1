using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonTorpedoBullet : Bullet
{
    public float explotionArea;

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
        RangeExplotion();
    }

    void RangeExplotion()
    {
        Collider2D[] asteroid = Physics2D.OverlapCircleAll(transform.position, explotionArea);

        foreach (var _objets in asteroid)
        {
            if (_objets.gameObject == gameObject) continue;

            var force = damageBullet * ((_objets.transform.position - transform.position).magnitude / explotionArea);

            var _col = gameObject.GetComponent<ITakeDamage>();

            if (_col != null)
            {
                _col.TakeDamage(force);
            }
        }
    }
}
