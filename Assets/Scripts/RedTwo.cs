using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedTwo : MonoBehaviour
{
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
        PlayerPrefs.SetInt("attempts", 0);

    }

}
