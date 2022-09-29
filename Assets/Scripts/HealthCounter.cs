using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthCounter : MonoBehaviour
{
    static public int healthCount; //���-�� ��
    public Text Text; //��������� ���� � �������

    void Start() //�������������� ����� ���������� �����
    {
        healthCount = 3; //���������� ��������� ���-�� ��
    }
    void OnTriggerEnter(Collider Collider) //��� ������������ ��������
    {
        if (Collider.CompareTag("Barrier")) //���� ������ � ��������� ����� ��� "Barrier"
        {
            Collider.gameObject.GetComponent<Collider>().enabled = false; //��������� ��� ���������
            Destroy(Collider.gameObject); //���������� ���
            healthCount--; //�������� �� �� �������
            Text.text = healthCount.ToString(); //���������� � �������
            if(healthCount <= 0) //���� �� ������ ��� ����� ����
            {
                Destroy(this.gameObject); //���������� ���������
                SceneManager.LoadScene(2);
            }
        }
    }
}
