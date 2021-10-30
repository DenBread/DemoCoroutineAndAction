using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private GameObject _cube; // ������
    private int _countCube; // ���-�� �����

    public static Action<int> AddCountCube; //������� �� ���������� ���-�� ����� � UI

    private void Start()
    {
        _countCube = 0;
        if(AddCountCube != null) AddCountCube(_countCube);;
        StartCoroutine(Spawn()); // ������ ��������
    }

    IEnumerator Spawn(float time = 1f)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Vector3 randomPos = new Vector3(UnityEngine.Random.Range(-3f,3f), transform.position.y, UnityEngine.Random.Range(-3f,3f)); // ��������� ������� ������ �� X � Z 

            GameObject obj = Instantiate(_cube, randomPos, Quaternion.identity); // ������� ���
            _countCube++; 
            if (AddCountCube != null) AddCountCube(_countCube);

            obj.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); // ��������� ���� ����
        }
    }
}
