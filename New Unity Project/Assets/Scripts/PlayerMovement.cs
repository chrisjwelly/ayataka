using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

        //This is a reference to the Rigidbody component called "rb"
    public Rigidbody RB;
    public float acceleration = 0.1f;
    public float forwardForce = 1000f;
    public float sidewaysForce = 75f;
    public float JumpForce = 350f;
    public bool jump = true;
    

    // "Fixed"update because we are using physics
    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown("space") && jump)
        {
            RB.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            jump = false;
        }

    }
    public void Switch_Jump()
    {
        if (jump == false && RB.position.x > -8.0f && RB.position.x < 8.0f)
        {
            jump = true;
        } }
        void FixedUpdate()
    {
        //acceleration
        forwardForce = forwardForce + acceleration;
        
        RB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")){
            RB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            RB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
      

        if (RB.position.y < -1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
    
    
    
}
