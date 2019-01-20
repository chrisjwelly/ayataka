using UnityEngine;
using UnityEngine.UI;
public class LifeLeftText : MonoBehaviour
{
    public Text LifeLeftNotice;

    // Update is called once per frame
    void Update()
    {
        int lives = FindObjectOfType<GameManagerScript>().lifeLeft;
        if (lives > 0)
        {
            if (lives == 3)
            {
                LifeLeftNotice.text = "I I I";
            }
            else if (lives == 2)
            {
                LifeLeftNotice.text = "I I";
            }
            else
            {
                LifeLeftNotice.text = "I";
            }
                                  ;
        } else
        {
            LifeLeftNotice.text = "You died";
        }

    }
}
