using UnityEngine;
using UnityEngine.UI;
public class LifeLeftText : MonoBehaviour
{
    public Text LifeLeftNotice;

    // Update is called once per frame
    void Update()
    {
        LifeLeftNotice.text = "You can be hit by bullet " +
                               FindObjectOfType<GameManagerScript>().lifeLeft.ToString("0")
                               + " more time(s)";// refer to game component
    }
}
