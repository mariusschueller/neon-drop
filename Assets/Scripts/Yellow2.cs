using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yellow2 : MonoBehaviour
{
    public void yellow2()
    {
        SceneManager.LoadScene("Yellow2");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
