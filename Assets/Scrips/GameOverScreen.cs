using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text finalscoretext;
    public score highscore;

    void Start()
    {
        gameObject.SetActive(false);
    }
    public void ActiveScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        finalscoretext.text = (highscore.Scorecounter * 10).ToString("0");
    }
   public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
