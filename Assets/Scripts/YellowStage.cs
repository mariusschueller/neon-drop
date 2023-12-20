using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YellowStage : MonoBehaviour
{
    public void Yellow()
    {
        SceneManager.LoadScene("Yellow");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
