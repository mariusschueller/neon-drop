using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btry : MonoBehaviour
{


    int bbegin;


    // Use this for initialization
    void Start()
    {
        bbegin = PlayerPrefs.GetInt("bbegin");

        PlayerPrefs.SetInt("bbegin", 1);



    }


}
