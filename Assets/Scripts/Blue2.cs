using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blue2 : MonoBehaviour
{

    public void blue2()
    {
        SceneManager.LoadScene("Blue2");
        PlayerPrefs.SetInt("attempts", 0);
    }

}

