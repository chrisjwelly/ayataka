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
    void FixedUpdate()
    {
        /* don't use GetKey because this is for all the duration
         * that the button is pressed down. GetKeyDown will
         * only return true for the single instant the button is pressed
         * down
         */
        if (Input.GetKeyDown("k"))
        {
            // currently the bullet will 'collide' with the obstacle
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet, obstacleInfo.position, obstacleInfo.rotation) as Rigidbody;
            bulletInstance.AddForce(0, 0, -3000);
        }
    }
}
