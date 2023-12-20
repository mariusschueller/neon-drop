using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orange2 : MonoBehaviour
{

    public void orange2()
    {
        SceneManager.LoadScene("Orange2");
        PlayerPrefs.SetInt("attempts", 0);
    }

}

