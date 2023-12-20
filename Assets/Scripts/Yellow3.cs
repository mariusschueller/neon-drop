using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yellow3 : MonoBehaviour
{
    public void yellow3()
    {
        SceneManager.LoadScene("Yellow3");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
