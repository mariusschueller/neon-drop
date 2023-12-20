using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orange : MonoBehaviour
{
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
