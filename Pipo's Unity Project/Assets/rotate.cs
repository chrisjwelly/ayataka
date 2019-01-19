// Rotate an object around its Y (upward) axis in response to
// left/right controls.
using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        if(Input.GetKey("k"))
        {
            rb.AddTorque(x, y, z);
        }
        
    }
}