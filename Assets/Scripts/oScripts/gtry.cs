using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gtry : MonoBehaviour
{


    int gbegin;


    // Use this for initialization
    void Start()
    {
        gbegin = PlayerPrefs.GetInt("gbegin");

        PlayerPrefs.SetInt("gbegin", 1);



    }


}
