using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBullet : MonoBehaviour
{
    public static PoolBullet Instance { get; private set; }

    public GameObject bulletPrefabs;

    public int totalBullet;

    public List<GameObject> _bullets = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
        InstanceBullet();
    }

    void InstanceBullet()
    {
        for (int i = 0; i < totalBullet; i++)
        {
            GameObject _b = Instantiate(bulletPrefabs);
            _b.SetActive(false);
            _bullets.Add(_b);
        }
    }

    public GameObject Get()
    {
        GameObject rect;

        if(_bullets.Count > 0)
        {
            rect = _bullets[_bullets.Count - 1];
            _bullets.RemoveAt(_bullets.Count - 1);
        }
        else
        {
            rect = Instantiate(bulletPrefabs);
        }

        rect.SetActive(true);

        return rect;
    }

    public void Retur(GameObject _bullet)
    {
        _bullet.SetActive(false);
        _bullets.Add(_bullet);
        transform.position = Vector2.zero;
    }
}
