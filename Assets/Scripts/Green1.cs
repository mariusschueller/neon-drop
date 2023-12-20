using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Green1 : MonoBehaviour
{
    public void green1()
    {
        SceneManager.LoadScene("Green1");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
