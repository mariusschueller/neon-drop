using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    int pause;
    int practice;
    

    public void Start()
    {
        practice = PlayerPrefs.GetInt("practice");

        pause = PlayerPrefs.GetInt("pause");

        

        PlayerPrefs.SetInt("pause", 0);

        if (practice == 0)
        Time.timeScale = 1;
        if (practice == 1)
        Time.timeScale = .60f;
        
    }
    public GameObject pausePanel2;

    public void PauseGame()
    {
        pausePanel2.SetActive(true);
        Time.timeScale = 0;
        PlayerPrefs.SetInt("pause", 1);
    }
    public void ResumeGame()
    {
        pausePanel2.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefs.SetInt("pause", 0);
    }
}
