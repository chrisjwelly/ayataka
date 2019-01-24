using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] obj;
    public Rigidbody RB2;
    private List<GameObject> activeObjs = new List<GameObject>();

    void Start()
    {
        spawn();
    }

    public float z = 45f;
    public float g_pos = 490f;
    public Transform ground;
    private float safe = 205.0f;
    private bool buffer = false;

    void FixedUpdate()
    {
        float z_pos = RB2.position.z;
        if (z_pos > z)
        {
            z += 160f;
            spawn();
            if (buffer == false)
            {
                buffer = true;
            }
        }
        if (z_pos > g_pos)
        {
            g_pos += + 1000f;
            Instantiate(ground, new Vector3(0, 0, g_pos), Quaternion.identity);
        }
    
        
    }
    void spawn()
    {
        for (int y = 0; y < 4; y++)
        {
            GameObject go;
            go = Instantiate(obj[Random.Range(0, obj.GetLength(0))], new Vector3(0, 1, z + y * 40), Quaternion.identity) as GameObject;
            activeObjs.Add(go);
            if (buffer)
            {
                Destroy(activeObjs[0]);
                activeObjs.RemoveAt(0);
            }
        }
    }
   
}   