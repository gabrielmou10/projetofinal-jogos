using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameoverPage;
    public GameObject ScoreShow;
    public GameObject Levelshow;
    

    public void Start()
    {
        Time.timeScale = 1; 

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void GameOver()
    {
        if (Score.score > PlayerPrefs.GetInt("highscore")){
            PlayerPrefs.SetInt("highscore", Score.score);
        }        
        gameoverPage.SetActive(true);
        //ScoreShow.SetActive(false);
        Time.timeScale = 0;
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void Update(){
        if (Score.score > 10 * SceneManager.GetActiveScene().buildIndex){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Level.level = SceneManager.GetActiveScene().buildIndex;


    }

}
