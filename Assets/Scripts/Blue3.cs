using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blue3 : MonoBehaviour
{

    public void blue3()
    {
        SceneManager.LoadScene("Blue3");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
