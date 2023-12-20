using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ystage : MonoBehaviour {


    int ybegin;



    // Use this for initialization
    void Start () {
        ybegin = PlayerPrefs.GetInt("ybegin");

        PlayerPrefs.SetInt("ybegin", 1);



    }


}
