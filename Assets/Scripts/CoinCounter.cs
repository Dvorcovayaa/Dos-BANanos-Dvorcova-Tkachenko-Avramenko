using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    int coinCount;
    public Text Text;
    void Start()
    {

    }
    void OnTriggerStay(Collider Collider)
    {
        if (Collider.CompareTag("Player")) coinCount++;
        Destroy(this.gameObject);
        Text.text = coinCount.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
