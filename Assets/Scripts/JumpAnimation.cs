using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    Animator Animator; //Обозначаем Аниматор
    void Start() //Обрабатывается перед отрисовкой кадра
    {
        Animator = gameObject.GetComponent<Animator>(); //Получаем аниматор с объекта
    }

    void Update() //Обрабатывается каждый кадр
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Если был нажат пробел
        {
            Animator.SetTrigger("JumpTrigger"); //Активировать триггер "JumpTrigger"
        }
    }
}
