using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfGenerator : MonoBehaviour
{
    public GameObject Shelf; //????????? ???? ? ???????? ?????
    void Start() //?????????????? ????? ?????????? ?????
    {
        StartCoroutine(GenerateShelfs()); //???????? ????????
    }
    IEnumerator GenerateShelfs()
    {
        while (true) //?????? ????
        {
            Instantiate(Shelf, new Vector3(Random.Range(-7f, 6.6f), 0, 30), Quaternion.Euler(0, Random.Range(0, 360), 0)); //??????? ?????? ?????
            yield return new WaitForSeconds(2.8f); //?????? 2.8 ???????
        }
    }
}