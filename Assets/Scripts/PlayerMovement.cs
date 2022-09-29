using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void FixedUpdate() //Обрабатывается один раз каждый отрезок времени
    {
        if (Input.GetKey(KeyCode.A)) //При нажатой клавише "A"
        {
            transform.position = transform.position + new Vector3(-5, 0, 0) * Time.deltaTime; //Меняем позицию персонажа по X влево
        }
        if (Input.GetKey(KeyCode.D)) //При нажатой клавише "D"
        {
            transform.position = transform.position + new Vector3(5, 0, 0) * Time.deltaTime; //Меняем позицию персонажа по X вправо
        }
       
    }
}
