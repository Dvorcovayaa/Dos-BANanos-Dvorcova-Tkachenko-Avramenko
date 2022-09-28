using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.z <= -130)
        {
            Destroy(this.gameObject);
        }
    }
}
