using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blue1 : MonoBehaviour
{
    public void blue1()
    {
        SceneManager.LoadScene("Blue1");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
