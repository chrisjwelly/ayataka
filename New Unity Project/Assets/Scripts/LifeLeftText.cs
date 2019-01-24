using UnityEngine;
using UnityEngine.UI;
public class LifeLeftText : MonoBehaviour
{
    public Text LifeLeftNotice;

    // Update is called once per frame
    public void died()
    {
        LifeLeftNotice.text = "You Died";
    }
    void Update()
    {
        int lives = FindObjectOfType<GameManagerScript>().lifeLeft;
        if (lives > 0)
        {
            if (lives == 3)
            {
                LifeLeftNotice.text = "❤ ❤ ❤";
            }
            else if (lives == 2)
            {
                LifeLeftNotice.text = "❤ ❤";
            }
            else
            {
                LifeLeftNotice.text = "❤";
            }
                                  ;
        } else
        {
            died();
        }

    }
}
