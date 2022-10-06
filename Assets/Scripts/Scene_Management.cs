using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Management : MonoBehaviour
{
    public GameObject startScreen;
    //public GameObject gameOver;

    void Awake() 
    {
        startScreen.SetActive(true);
        //gameOver.SetActive(false);
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    public void OnStartButton()
    {
        Time.timeScale = 1;
        startScreen.SetActive(false);
    }

    // public void OnGameOver()
    // {
    //     //gameOver.SetActive(true);
    //     Debug.Log(gameOver.SetActive(false));
    // }

    public void OnReplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
