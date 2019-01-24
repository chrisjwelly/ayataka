using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerScript gamemanager;

    void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
}
