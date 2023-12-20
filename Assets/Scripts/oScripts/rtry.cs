using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtry : MonoBehaviour
{


    int rbegin;


    // Use this for initialization
    void Start()
    {
        rbegin = PlayerPrefs.GetInt("rbegin");

        PlayerPrefs.SetInt("rbegin", 1);



    }


}
