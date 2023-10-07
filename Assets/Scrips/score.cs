using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    public Text highscore;
    public float Scorecounter = 0f;
    void Update()
    {
        Scorecounter += Time.deltaTime;
        scoretext.text = (Scorecounter*10).ToString("Score: 0");
    }
}
