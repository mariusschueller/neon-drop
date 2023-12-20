using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Green2 : MonoBehaviour
{

    public void green2()
    {
        SceneManager.LoadScene("Green2");
        PlayerPrefs.SetInt("attempts", 0);
    }

}

