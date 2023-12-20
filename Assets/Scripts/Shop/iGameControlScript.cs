using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class iGameControlScript : MonoBehaviour
{


    int ibegin;
    int vbegin;



    public GameObject iball;
    public GameObject vball;




    // Use this for initialization
    void Start()
    {
        ibegin = PlayerPrefs.GetInt("ibegin");
        vbegin = PlayerPrefs.GetInt("vbegin");





        if (ibegin == 1)
            iball.SetActive(true);

        else
            iball.SetActive(false);




        if (vbegin == 1)
            vball.SetActive(true);

        else
            vball.SetActive(false);


    }

    // Update is called once per frame

}
