using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void FixedUpdate() //�������������� ���� ��� ������ ������� �������
    {
        if (Input.GetKey(KeyCode.A)) //��� ������� ������� "A"
        {
            transform.position = transform.position + new Vector3(-5, 0, 0) * Time.deltaTime; //������ ������� ��������� �� X �����
        }
        if (Input.GetKey(KeyCode.D)) //��� ������� ������� "D"
        {
            transform.position = transform.position + new Vector3(5, 0, 0) * Time.deltaTime; //������ ������� ��������� �� X ������
        }
       
    }
}
