using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _respawn;
    private float _topX, _bottomX, _leftY, _rightY;
    private Vector3 _vecTop, _vecBottom, _vecLeft, _vecRight;

    private void Start()
    {
        StartCoroutine(Spawn(_respawn));
    }

    private IEnumerator Spawn(float time = 1f)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            RandomPos();

            Instantiate(_enemy, _vecTop, Quaternion.identity);
            Instantiate(_enemy, _vecBottom, Quaternion.identity);
            Instantiate(_enemy, _vecLeft, Quaternion.identity);
            Instantiate(_enemy, _vecRight, Quaternion.identity);
        }
    }

    private void RandomPos()
    {
        _topX = Random.Range(-12f, 12f);
        _bottomX = Random.Range(-12f, 12f);
        _leftY = Random.Range(-7f, 7f);
        _rightY = Random.Range(-7f, 7f);

        _vecTop = new Vector3(_topX, 7f);
        _vecBottom = new Vector3(_bottomX, -7f);
        _vecLeft = new Vector3(-12f, _leftY);
        _vecRight = new Vector3(12f, _rightY);
    }
}
