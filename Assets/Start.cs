using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public Text Highscoreshow;

    // Update is called once per frame
    private void Update()
    {
        Highscoreshow.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
