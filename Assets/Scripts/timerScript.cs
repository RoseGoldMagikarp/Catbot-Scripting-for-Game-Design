using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class timerScript : MonoBehaviour
{
    public Text uiText;
    public float mainTimer;
    public float timer;
    public static float finalScore;
    public GameObject Player;

    void Start()
    {
        timer = mainTimer;
    }

    void Update()
    {
        finalScore = timer;

        if (Player.activeInHierarchy == true)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F");
        }
        else if (Player.activeInHierarchy == false)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
