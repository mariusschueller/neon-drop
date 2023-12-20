using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orange3 : MonoBehaviour
{

    public void orange3()
    {
        SceneManager.LoadScene("Orange3");
        PlayerPrefs.SetInt("attempts", 0);
    }

}

