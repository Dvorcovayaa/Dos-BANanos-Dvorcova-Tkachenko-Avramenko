using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfGenerator : MonoBehaviour
{
    public GameObject Shelf; //Публичное поле с объектом полки
    void Start() //Обрабатывается перед отрисовкой кадра
    {
        StartCoroutine(GenerateShelfs()); //Стартуем куратину
    }
    IEnumerator GenerateShelfs()
    {
        while (true) //Вечный цикл
        {
            Instantiate(Shelf, new Vector3(Random.Range(-7f, 6.6f), 0, 30), Quaternion.Euler(0, Random.Range(0, 360), 0)); //Создаем префаб полки
            yield return new WaitForSeconds(2.8f); //Каждые 2.8 секунды
        }
    }
}