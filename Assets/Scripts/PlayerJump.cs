using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    bool isGround; //Переменная со значениями истина/ложь
    Rigidbody Rigidbody; //Обозначаем Rigidbody
    public float jumpAmount; //Модификатор прыжка
    public AudioSource AudioSource; //Поле для AudioSource
    void Start() //Обрабатывается перед отрисовкой кадра
    {
        Rigidbody = GetComponent<Rigidbody>(); //Получаем Rigidbody
        AudioSource = GetComponent<AudioSource>(); //Получаем AudioSorce
    }
    void OnTriggerStay(Collider Collider) //Обрабатывается если персонаж находиться в зоне триггера
    {
        if (Collider.CompareTag("Ground")) isGround = true; //И если тэг объекта с триггером "Ground", то меняем значение "isGround"
    }
    void OnTriggerExit(Collider Collider) //Обрабатывается если персонаж выходит из зоны триггера
    {
        if (Collider.CompareTag("Ground")) isGround = false; //И если тэг объекта с триггером "Ground", то меняем значение "isGround"
    }
    void Update() //Обрабатывается каждый кадр
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround) //Если был нажат пробел и isGround = true
        {
            Rigidbody.AddForce(new Vector3(0, 2, 0) * jumpAmount, ForceMode.Impulse); //Задаем импульс по оси Y
            AudioSource.Play(); //Проигрываем звук
        }
    }
}
