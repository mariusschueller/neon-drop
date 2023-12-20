using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indigo1 : MonoBehaviour
{
    public void indigo1()
    {
        SceneManager.LoadScene("Indigo1");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
