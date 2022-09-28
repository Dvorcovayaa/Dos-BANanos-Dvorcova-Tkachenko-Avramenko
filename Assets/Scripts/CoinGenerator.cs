using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject Coin;
    void Start()
    {
        StartCoroutine(GenerateCoins());
    }
    IEnumerator GenerateCoins ()
    {
        while (true)
        {
            Instantiate(Coin, new Vector3(Random.Range(-10f, 9.7f), 1.3f, 30), Quaternion.identity);
            yield return new WaitForSeconds(15f);
        }
    }

    void Update()
    {
        
    }
}
