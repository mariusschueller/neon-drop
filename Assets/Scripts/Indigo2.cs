using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indigo2 : MonoBehaviour
{

    public void indigo2()
    {
        SceneManager.LoadScene("Indigo2");
        PlayerPrefs.SetInt("attempts", 0);
    }

}

