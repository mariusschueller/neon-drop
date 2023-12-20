using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itry : MonoBehaviour
{


    int ibegin;


    // Use this for initialization
    void Start()
    {
        ibegin = PlayerPrefs.GetInt("ibegin");

        PlayerPrefs.SetInt("ibegin", 1);



    }


}
