using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    float jumpAmount = 4.5f;
    void Start()
    {
 
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(new Vector3(0, 2, 0) * jumpAmount, ForceMode.VelocityChange);
        }
    }
}
