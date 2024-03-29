using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWays = 120f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(sideWays*Time.deltaTime , 0, 0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce( -sideWays * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
