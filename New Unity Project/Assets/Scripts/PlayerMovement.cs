using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

        //This is a reference to the Rigidbody component called "rb"
    public Rigidbody RB;
    public float forwardForce = 2000f;
    public float sidewaysForce = 50f;
    private bool jump = true;

    // "Fixed"update because we are using physics
    // Update is called once per frame
    
    void FixedUpdate()
    {
        RB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")){
            RB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            RB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("space") && jump)
        {
            RB.AddForce(0, 300 * Time.deltaTime, 0, ForceMode.VelocityChange);
            jump = false;
                }
        float pos_y = RB.position.y;
        void ju ()
            {
                jump = true;
            }

        if (jump == false && pos_y > 0.95f && pos_y < 1.05f)
        {
            

            Invoke("ju", 0.1f);
            
        }
        
        if (pos_y < -1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
    
}
