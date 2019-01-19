﻿using System.Collections;
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
    void FixedUpdate()
    {
        if (Input.GetKey("k"))
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet) as Rigidbody;
            bulletInstance.AddForce(0, 0, -3000);
        }
    }
}
