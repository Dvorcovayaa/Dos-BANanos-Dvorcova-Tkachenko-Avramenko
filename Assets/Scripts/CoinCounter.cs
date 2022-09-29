using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    static public int coinCount; //Кол-во монеток
    public Text Text; //Публичное поле с текстом

    void Start() //Обрабатывается перед отрисовкой кадра
    {
        coinCount = 0; //Определяем начальное кол-во монеток
    }
    void OnTriggerEnter(Collider Collider) //При срабатывании триггера
    {
        if (Collider.CompareTag("Coin")) //Если объект с триггером имеет тэг "Coin"
        {
            Collider.gameObject.GetComponent<Collider>().enabled = false; //Отключаем его коллайдер
            Destroy(Collider.gameObject); //Уничтожаем его
            coinCount++; //Прибавляем монетку
            Text.text = coinCount.ToString(); //Записываем в счетчик
            if (coinCount%10 == 0) //Если количество монеток кратно 10
            {
                HealthCounter.healthCount++; //Добавляем к ХП единицу
                HealthCounter.FindObjectOfType<Text>().text = HealthCounter.healthCount.ToString(); //Записываем в счетчик
            }
        }

    }
}
