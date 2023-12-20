using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    public GameObject red;
    public GameObject orange;
    public GameObject yellow;
    public GameObject green;
    public GameObject blue;
    public GameObject indigo;
    public GameObject violet;

    int colorchanger;

    
    
    // Update is called once per frame
    void Update()
    {
        colorchanger++;

        if (colorchanger >= 25)
            orange.SetActive(true);
        else
            orange.SetActive(false);

        if (colorchanger >= 50)
            yellow.SetActive(true);
        else
            yellow.SetActive(false);

        if (colorchanger >= 75)
            green.SetActive(true);
        else
            green.SetActive(false);

        if (colorchanger >= 100)
            blue.SetActive(true);
        else
            blue.SetActive(false);

        if (colorchanger >= 125)
            indigo.SetActive(true);
        else
            indigo.SetActive(false);

        if (colorchanger >= 150)
            violet.SetActive(true);
        else
            violet.SetActive(false);


        if (colorchanger >= 175)
            colorchanger = 0;
    }
}
