using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public PlayerMovement movement;

    public GameObject completeLevelUI;

    // problematic because you can manually change it in the editor ._.
    public int lifeLeft = 5;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            movement.enabled = false; 
            Invoke("Restart", restartDelay);
        }
    }

    public void GotHitByBullet()
    {
        if (lifeLeft != 0)
        {
            lifeLeft = lifeLeft - 1;
        }
        else
        {
            EndGame();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
