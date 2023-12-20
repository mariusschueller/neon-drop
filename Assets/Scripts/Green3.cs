using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Green3 : MonoBehaviour
{

    public void green3()
    {
        SceneManager.LoadScene("Green3");
        PlayerPrefs.SetInt("attempts", 0);
    }

}

