using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    bool isGround; //���������� �� ���������� ������/����
    Rigidbody Rigidbody; //���������� Rigidbody
    public float jumpAmount; //����������� ������
    void Start() //�������������� ����� ���������� �����
    {
        Rigidbody = GetComponent<Rigidbody>(); //�������� Rigidbody
    }
    void OnTriggerStay(Collider Collider) //�������������� ���� �������� ���������� � ���� ��������
    {
        if (Collider.CompareTag("Ground")) isGround = true; //� ���� ��� ������� � ��������� "Ground", �� ������ �������� "isGround"
    }
    void OnTriggerExit(Collider Collider) //�������������� ���� �������� ������� �� ���� ��������
    {
        if (Collider.CompareTag("Ground")) isGround = false; //� ���� ��� ������� � ��������� "Ground", �� ������ �������� "isGround"
    }
    void FixedUpdate() //�������������� ���� ��� ������ ������� �������
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround) //���� ��� ����� ������ � isGround = true
        {
            Rigidbody.AddForce(new Vector3(0, 2, 0) * jumpAmount, ForceMode.Impulse); //������ ������� �� ��� Y
        }
    }
}
