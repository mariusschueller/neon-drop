using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Violet2 : MonoBehaviour
{
    public void violet2()
    {
        SceneManager.LoadScene("Violet2");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
