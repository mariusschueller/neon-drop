using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Violet3 : MonoBehaviour
{
    public void violet3()
    {
        SceneManager.LoadScene("Violet3");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
