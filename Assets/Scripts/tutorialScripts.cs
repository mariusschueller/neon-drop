using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScripts : MonoBehaviour
{
    int tutorial;
    public GameObject stageselect;
    public GameObject levelselect;
    public GameObject levelplay;
    public GameObject levelstopper;
    // Start is called before the first frame update
    void Awake()
    {
        tutorial = PlayerPrefs.GetInt("tutorialwork");
    }

    private void Start()
    {
        if (tutorial == 0)
            stageselect.SetActive(true);
        if (tutorial == 1)
            levelselect.SetActive(true);
        if (tutorial == 2)
            levelplay.SetActive(true);
        if (tutorial <= 3)
            tutorial++;
        if (tutorial <= 3)
            PlayerPrefs.SetInt("tutorialwork", tutorial);
        if (tutorial <= 3)
            levelstopper.SetActive(true);
    }

    
    public void readyToPlay()
    {
        levelplay.SetActive(false);
        levelstopper.SetActive(false);
    }
}
