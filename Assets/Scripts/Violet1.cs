using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Violet1 : MonoBehaviour
{
    public void violet1()
    {
        SceneManager.LoadScene("Violet1");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
