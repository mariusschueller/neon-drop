using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class practice : MonoBehaviour {

    int practices;
    public Button on;
    public Button off;

    // Use this for initialization

    private void Start()
    {
        practices = PlayerPrefs.GetInt("practice");
        if (practices == 1)
            on.gameObject.SetActive(false);
        if (practices == 0)
            off.gameObject.SetActive(false);
    }

    // Update is called once per frame

    public void turnon() 
    {
        practices = 1;
        on.gameObject.SetActive(false);
        off.gameObject.SetActive(true);
        PlayerPrefs.SetInt("practice", 1);
    }

    public void turnoff()
    {
        practices = 0;
        on.gameObject.SetActive(true);
        off.gameObject.SetActive(false);
        PlayerPrefs.SetInt("practice", 0);
    }

}