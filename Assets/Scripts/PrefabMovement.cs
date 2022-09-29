using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    int speedAmount = 10; //����������� ��������
    void Start() //���������� �� ��������� �����
    {
        StartCoroutine(SpeedBoost()); //������� ��������
    }
    IEnumerator SpeedBoost()
    {
        while (true) //������ ����
        {
            speedAmount++; //����������� � ������������ �������� �������
            yield return new WaitForSeconds(5.8f); //������ 5.8 ������
        }
    }
    void FixedUpdate() //�������������� ���� ��� ������ ������� �������
    {
        transform.position = transform.position + new Vector3(0, 0, -speedAmount) * Time.deltaTime; //�������� ������� �� ��� Z �����
    }
}
