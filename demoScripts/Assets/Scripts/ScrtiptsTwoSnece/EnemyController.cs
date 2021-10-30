using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody _rb;
    private bool _isCollision;
    [SerializeField] private float _force;
    [SerializeField] private GameObject _explosionEfffect;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!_isCollision)
        {
            Vector3 f = Vector3.zero - transform.position;
            f = f.normalized * _force;
            _rb.AddForce(f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            _isCollision = true;
            Destroy(gameObject);
            CinemachineShake.Instance.ShakeCamera(5f, 0.1f);
            GameObject gm = Instantiate(_explosionEfffect, transform.position, Quaternion.identity);
            Destroy(gm, 2f);
        }
    }
}
