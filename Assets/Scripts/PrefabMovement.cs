using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    int speedAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedBoost());
    }
    IEnumerator SpeedBoost()
    {
        while (true)
        {
            speedAmount++;
            yield return new WaitForSeconds(10f);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, 0, -speedAmount) * Time.deltaTime;
    }
}
