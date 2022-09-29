using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthCounter : MonoBehaviour
{
    static public int healthCount; //Кол-во ХП
    public Text Text; //Публичное поле с текстом

    void Start() //Обрабатывается перед отрисовкой кадра
    {
        healthCount = 3; //Определяем начальное кол-во ХП
    }
    void OnTriggerEnter(Collider Collider) //При срабатывании триггера
    {
        if (Collider.CompareTag("Barrier")) //Если объект с триггером имеет тэг "Barrier"
        {
            Collider.gameObject.GetComponent<Collider>().enabled = false; //Отключаем его коллайдер
            Destroy(Collider.gameObject); //Уничтожаем его
            healthCount--; //Убавляем ХП на единицу
            Text.text = healthCount.ToString(); //Записываем в счетчик
            if(healthCount <= 0) //Если ХП меньше или равен нулю
            {
                Destroy(this.gameObject); //Уничтожаем персонажа
                SceneManager.LoadScene(2);
            }
        }
    }
}
