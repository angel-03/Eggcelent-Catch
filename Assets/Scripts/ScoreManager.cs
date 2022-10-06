using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int count;
    public Text scoreText;
    public Text lifeText;
    Scene_Management sceneManagement;
    bool check;
    public GameObject gameOver;

    void Start()
    {
        score=0;
        count=3;
        gameOver.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        lifeText.text = count.ToString();
        if(count<=0)
        {
            OnGameOver();
            Time.timeScale = 0;
        }
        if(score<0)
        {
            score=0;
        }
        scoreText.text = score.ToString();
    }
    
    public void OnGameOver()
    {
        gameOver.SetActive(true);
        Debug.Log(gameOver);
    }
}
