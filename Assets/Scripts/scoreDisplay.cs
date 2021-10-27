using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scoreDisplay : MonoBehaviour
{
    public Text uiText;
    public static float playerScore;

    void Start()
    {
        playerScore = timerScript.finalScore;
        uiText.text = "Time: " + playerScore.ToString("F") + " seconds";
    }

}
