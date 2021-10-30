using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _vec;
    [SerializeField] private float _powerDir;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _vec = Vector3.right;

    }

    private void FixedUpdate()
    {
        _rb.AddRelativeForce(_vec * _powerDir * Time.fixedDeltaTime, ForceMode.Impulse);
        Destroy(gameObject, 3f);
    }


}
