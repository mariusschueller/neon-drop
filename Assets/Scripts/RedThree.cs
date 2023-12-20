using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedThree : MonoBehaviour
{
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
        PlayerPrefs.SetInt("attempts", 0);
    }

}
