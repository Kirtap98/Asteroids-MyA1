using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speedPlayer;
    public float rotatePlayer;

    

    Rigidbody2D _rg2d;

    void Start()
    {
        _rg2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //ShootBullet();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()
    {
       _rg2d.AddForce(transform.up * Input.GetAxis("Vertical") * speedPlayer, ForceMode2D.Impulse);
    }

    void RotatePlayer()
    {
        _rg2d.rotation += -Input.GetAxis("Horizontal") * rotatePlayer;
    }

    /*void ShootBullet()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PoolBullet.Instance.Get().transform.up=point.localPosition ;
        }
    }*/
}
