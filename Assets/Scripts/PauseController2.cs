using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController2 : MonoBehaviour
{
    int pause;

        public void Start()
    {
        Time.timeScale = 1;
        pause = PlayerPrefs.GetInt("pause");

        PlayerPrefs.SetInt("pause", 0);
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
