using UnityEngine;

public class forward : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("l"))
        {
            rb.AddForce(0, 0, -200);
        }


    }
}