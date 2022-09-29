using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    int speedAmount = 10; //Модификатор движения
    void Start() //Вызывается до отрисовки кадра
    {
        StartCoroutine(SpeedBoost()); //Создаем куратину
    }
    IEnumerator SpeedBoost()
    {
        while (true) //Вечный цикл
        {
            speedAmount++; //Прибавдляем к модификатору движения единицу
            yield return new WaitForSeconds(5.8f); //Каждые 5.8 секунд
        }
    }
    void FixedUpdate() //Обрабатывается один раз каждый отрезок времени
    {
        transform.position = transform.position + new Vector3(0, 0, -speedAmount) * Time.deltaTime; //Сдвигаем префабы по оси Z назад
    }
}
