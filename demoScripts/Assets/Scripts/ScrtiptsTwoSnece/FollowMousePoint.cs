using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowMousePoint : MonoBehaviour
{
    private void Update()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = transform.position.z - Camera.main.transform.position.z; // ��� ������ ��� ������������� ������ ����������
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //��������� ���� �� �������� � ������� ����������
        var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);//���� ����� �������� �� ������� � ���� � ���� �
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);//������� ����� �� ��������
    }
}
