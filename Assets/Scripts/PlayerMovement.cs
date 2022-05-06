using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        
       
    }

    void FixedUpdate()
    {

        rb.AddForce(0, 0, fowardForce * Time.deltaTime);
        
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // ForceMode.VelocityChange completely ignores the mass of the object
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
