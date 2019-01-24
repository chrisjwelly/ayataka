using UnityEngine;

public class Self_Destruct : MonoBehaviour
{
    public float lifetime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
