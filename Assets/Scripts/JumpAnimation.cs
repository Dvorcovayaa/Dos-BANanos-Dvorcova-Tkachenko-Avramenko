using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    Animator Animator; //���������� ��������
    void Start() //�������������� ����� ���������� �����
    {
        Animator = gameObject.GetComponent<Animator>(); //�������� �������� � �������
    }

    void Update() //�������������� ������ ����
    {
        if (Input.GetKeyDown(KeyCode.Space)) //���� ��� ����� ������
        {
            Animator.SetTrigger("JumpTrigger"); //������������ ������� "JumpTrigger"
        }
    }
}
