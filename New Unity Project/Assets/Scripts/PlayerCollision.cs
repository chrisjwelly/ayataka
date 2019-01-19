using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            
            FindObjectOfType<GameManagerScript>().EndGame();
        }

        if (collisionInfo.collider.tag == "ground")
        {
            FindObjectOfType<PlayerMovement>().Switch_Jump();
           
        }

        if (collisionInfo.collider.tag == "Bullet")
        {
            FindObjectOfType<GameManagerScript>().GotHitByBullet();
        }
    }
    

}