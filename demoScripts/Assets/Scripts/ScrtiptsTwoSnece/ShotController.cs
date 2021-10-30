using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _pointGun;
    [SerializeField] private Transform _rotTank;
    [SerializeField] private int _countBullet;
    [SerializeField] private float _recharge;

    private void Update()
    {
        CreatBullet();
    }

    private void CreatBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            
            GameObject bullet = Instantiate(_bullet, _pointGun.transform.position, _rotTank.rotation);
            _countBullet--;
        }

        if (_countBullet <= 0)
        {

        }
    }
}
