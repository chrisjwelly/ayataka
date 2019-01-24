using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// plan:
/*
 * 1. Create prefab for bullet (Done!)
 * 2. Instantiate the bullet [from the obstacle]
 * 3. If (get key smth smth) -> Shoot the bullet [by addForce?]
 * 4. 
 */
public class Shooting2 : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform obstacleInfo;
    public Rigidbody OB;
    
    public Transform player;
    // distance between the obstacle and the player must be lower than this value before shooting
    public float distanceBetween = 40f;
    public float bulletForce = 3000f;
    public float sidewaysF = 40f;
    public void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    void FixedUpdate()
    {
        float actualDistance = obstacleInfo.position.z - player.position.z;

        // > 0 is for when the player has moved past the obstacle

        if (actualDistance < distanceBetween && actualDistance > 0)

        {
            /* don't use GetKey because this is for all the duration
             * that the button is pressed down. GetKeyDown will
             * only return true for the single instant the button is pressed
             * down
             */
            Quaternion S_angle = Quaternion.Euler(90, 0, 0);
            if (Input.GetKeyDown("/"))
            {
                Rigidbody bulletInstance;
                Rigidbody bulletInstance2;
                Rigidbody bulletInstance3;
                bulletInstance = Instantiate(bullet, obstacleInfo.position, S_angle) as Rigidbody;
                bulletInstance2 = Instantiate(bullet, new Vector3(obstacleInfo.position.x - 2, obstacleInfo.position.y, obstacleInfo.position.z), S_angle) as Rigidbody;
                bulletInstance3= Instantiate(bullet, new Vector3(obstacleInfo.position.x + 2, obstacleInfo.position.y, obstacleInfo.position.z), S_angle) as Rigidbody;
                bulletInstance.AddForce(0, 0, -bulletForce);
                bulletInstance2.AddForce(0, 0, -bulletForce);
                bulletInstance3.AddForce(0, 0, -bulletForce);
                // I LOVE IGNORE COLLISION
                Physics.IgnoreCollision(bulletInstance.GetComponent<Collider>(), GetComponent<Collider>());
                Physics.IgnoreCollision(bulletInstance2.GetComponent<Collider>(), GetComponent<Collider>());
                Physics.IgnoreCollision(bulletInstance3.GetComponent<Collider>(), GetComponent<Collider>());

            }
            if (Input.GetKey("up"))
            {
                OB.MovePosition(new Vector3 (OB.position.x, OB.position.y + 0.1f, OB.position.z));
                //OB.AddForce(0, sidewaysF * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("down"))
            {
                OB.MovePosition(new Vector3(OB.position.x, OB.position.y - 0.1f, OB.position.z));
                    //OB.AddForce(0, -sidewaysF * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
           

        }
    }
}