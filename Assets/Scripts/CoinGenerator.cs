using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject Coin; //Публичное поле с объектом монетки
    void Start() //Обрабатывается перед отрисовкой кадра
    {
        StartCoroutine(GenerateCoins()); //Стартуем куратину
    }
    IEnumerator GenerateCoins ()
    {
        while (true) //Вечный цикл
        {
            Instantiate(Coin, new Vector3(Random.Range(-10f, 9.7f), 1.3f, 30), Quaternion.identity); //Создаем префаб монетки
            yield return new WaitForSeconds(15f); //Каждые 15 секунд
        }
    }
}
