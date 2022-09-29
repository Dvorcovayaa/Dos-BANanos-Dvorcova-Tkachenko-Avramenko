using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateGenerator : MonoBehaviour
{
    public GameObject Crate; //Публичное поле с объектом ящика
    void Start() //Обрабатывается перед отрисовкой кадра
    {
        StartCoroutine(GenerateCrates()); //Стартуем куратину
    }
    IEnumerator GenerateCrates()
    {
        while (true) //Вечный цикл
        {
            Instantiate(Crate, new Vector3(Random.Range(-9f, 9.3f), 0, 30), Quaternion.Euler(0, Random.Range(0, 360), 0)); //Создаем префаб ящика
            yield return new WaitForSeconds(1.53f); //Каждые 1.53 секунды
        }
    }
}