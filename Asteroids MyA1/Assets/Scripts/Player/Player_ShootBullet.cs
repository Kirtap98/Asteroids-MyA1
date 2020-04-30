using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ShootBullet : MonoBehaviour
{
    public void FixedUpdate()
    {
        ShootBullet();
    }
    void ShootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PoolBullet.Instance.Get().transform.position=transform.position;
        }
    }
}
