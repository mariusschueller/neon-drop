using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OGameControlScript : MonoBehaviour
{


    int rbegin;
    int obegin;
    int ybegin;
    int gbegin;
    int bbegin;
    

    public GameObject rball;
    public GameObject oball;
    public GameObject yball;
    public GameObject gball;
    public GameObject bball;
    
    



    // Use this for initialization
    void Start()
    {
        rbegin = PlayerPrefs.GetInt("rbegin");
        obegin = PlayerPrefs.GetInt("obegin");
        ybegin = PlayerPrefs.GetInt("ybegin");
        gbegin = PlayerPrefs.GetInt("gbegin");
        bbegin = PlayerPrefs.GetInt("bbegin");





        if (rbegin == 1)
            rball.SetActive(true);

        else
            rball.SetActive(false);




        if (obegin == 2)
            oball.SetActive(true);

        else
            oball.SetActive(false);




        if (ybegin == 1)
            yball.SetActive(true);

        else
            yball.SetActive(false);




        if (gbegin == 1)
            gball.SetActive(true);

        else
            gball.SetActive(false);




        if (bbegin == 1)
            bball.SetActive(true);

        else
            bball.SetActive(false);




    }

    // Update is called once per frame

}
