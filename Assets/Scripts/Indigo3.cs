using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indigo3 : MonoBehaviour
{

    public void indigo3()
    {
        SceneManager.LoadScene("Indigo3");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
