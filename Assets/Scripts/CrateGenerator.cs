using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateGenerator : MonoBehaviour
{
    public GameObject Crate;
    void Start()
    {
        StartCoroutine(GenerateCrates());
    }
    IEnumerator GenerateCrates()
    {
        while (true)
        {
            Instantiate(Crate, new Vector3(Random.Range(-9f, 9.3f), 0, 30), Quaternion.Euler(0, Random.Range(0, 360), 0));
            yield return new WaitForSeconds(2.3f);
        }
    }

    void Update()
    {

    }
}