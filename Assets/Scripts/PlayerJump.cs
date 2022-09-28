using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    bool isGround;
    Rigidbody Rigidbody;
    public float jumpAmount;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }
    void OnTriggerStay(Collider Collider)
    {
        if (Collider.CompareTag("Ground")) isGround = true;
    }
    void OnTriggerExit(Collider Collider)
    {
        if (Collider.CompareTag("Ground")) isGround = false;
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            Rigidbody.AddForce(new Vector3(0, 2, 0) * jumpAmount, ForceMode.Impulse);
        }
    }
}
