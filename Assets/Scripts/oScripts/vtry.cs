using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vtry : MonoBehaviour
{


    int vbegin;


    // Use this for initialization
    void Start()
    {
        vbegin = PlayerPrefs.GetInt("vbegin");

        PlayerPrefs.SetInt("vbegin", 1);



    }


}
