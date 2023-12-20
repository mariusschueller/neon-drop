using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1Back : MonoBehaviour
{
    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

}
