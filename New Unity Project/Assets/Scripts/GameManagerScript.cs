using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public PlayerMovement movement;

    public GameObject completeLevelUI;


    // problematic because you can manually change it in the editor ._.
    public int lifeLeft = 3;

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
            lifeLeft = 0;
            Invoke("Restart", restartDelay);
            
        }
    }

    public void ReduceLife()
    {
        if (lifeLeft > 1) // not != 0 because starting from after one shot you should end game alrd
        {
            lifeLeft = lifeLeft - 1;
        }
        else
        {
            lifeLeft = lifeLeft - 1;
            EndGame();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}