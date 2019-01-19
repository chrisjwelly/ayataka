using System.Collections;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] obj;
    public Rigidbody RB2;
    

    void Start()
    {
        spawn();
    }
    
    public float z = 45f;
    public float g_pos = 490f;
    public Transform ground;
    void FixedUpdate()
    {
        float z_pos = RB2.position.z;
        if (z_pos > z)
        {
            z = z + 40f;
            spawn();
            
        }
        if(z_pos > g_pos)
        {
            g_pos = g_pos + 1000f;
            Instantiate(ground, new Vector3(0, 0, g_pos), Quaternion.identity);
        }
    }
    void spawn()
    {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], new Vector3(0, 1, z), Quaternion.identity);
    }
}
