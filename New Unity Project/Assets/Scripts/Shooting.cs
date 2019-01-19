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
public class Shooting : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform obstacleInfo;
    public Transform playerInfo;
    public int distanceBetween = 50; // distance between the obstacle and the player must be lower than this value
    public float bulletForce = 3000f;

    void FixedUpdate()
    {
        float actualDistance;
        actualDistance = obstacleInfo.position.z - playerInfo.position.z;
        // > 0 is for when the player has moved past the obstacle
        if (actualDistance < distanceBetween && actualDistance > 0)
        {
            /* don't use GetKey because this is for all the duration
             * that the button is pressed down. GetKeyDown will
             * only return true for the single instant the button is pressed
             * down
             */
            if (Input.GetKeyDown("k"))
            {
                Rigidbody bulletInstance;
                bulletInstance = Instantiate(bullet, obstacleInfo.position, obstacleInfo.rotation) as Rigidbody;
                bulletInstance.AddForce(0, 0, -bulletForce);
                // I LOVE IGNORE COLLISION
                Physics.IgnoreCollision(bulletInstance.GetComponent<Collider>(), GetComponent<Collider>());
            }
        }
        Debug.Log(actualDistance); // add a string here to help you maybe
    }
}
