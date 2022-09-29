using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    void Update() //Обрабатывается каждый кадр
    {
        transform.Rotate(new Vector3(0, 75, 0) * Time.deltaTime); //Меняем вращение монетки относительно оси Y
    }
}
