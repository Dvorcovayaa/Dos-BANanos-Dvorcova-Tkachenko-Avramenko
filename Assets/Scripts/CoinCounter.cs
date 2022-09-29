using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    static public int coinCount; //���-�� �������
    public Text Text; //��������� ���� � �������

    void Start() //�������������� ����� ���������� �����
    {
        coinCount = 0; //���������� ��������� ���-�� �������
    }
    void OnTriggerEnter(Collider Collider) //��� ������������ ��������
    {
        if (Collider.CompareTag("Coin")) //���� ������ � ��������� ����� ��� "Coin"
        {
            Collider.gameObject.GetComponent<Collider>().enabled = false; //��������� ��� ���������
            Destroy(Collider.gameObject); //���������� ���
            coinCount++; //���������� �������
            Text.text = coinCount.ToString(); //���������� � �������
            if (coinCount%10 == 0) //���� ���������� ������� ������ 10
            {
                HealthCounter.healthCount++; //��������� � �� �������
                HealthCounter.FindObjectOfType<Text>().text = HealthCounter.healthCount.ToString(); //���������� � �������
            }
        }

    }
}
