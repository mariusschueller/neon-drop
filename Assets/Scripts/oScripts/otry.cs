using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otry : MonoBehaviour
{


    int obegin;


    // Use this for initialization
    void Start()
    {
        obegin = PlayerPrefs.GetInt("obegin");

        PlayerPrefs.SetInt("obegin", 2);



    }


}
