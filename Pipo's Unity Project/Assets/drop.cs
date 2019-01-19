using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public Rigidbody rb;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("n"))
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("m"))
        {
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("j"))
        {
            rb.useGravity = true;
            
        }


    }
}
