using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{
    void FixedUpdate() //�������������� ���� ��� ������ ������� �������
    {
        if (transform.position.z <= -140) //���� ������� ������� ������ -140
        {
            Destroy(this.gameObject); //���������� ���
        }
    }
}
