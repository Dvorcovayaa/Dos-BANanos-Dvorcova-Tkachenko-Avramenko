using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{
    void FixedUpdate() //Обрабатывается один раз каждый отрезок времени
    {
        if (transform.position.z <= -140) //Если позиция префаба меньше -140
        {
            Destroy(this.gameObject); //Уничтожаем его
        }
    }
}
