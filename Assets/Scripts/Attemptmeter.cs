using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attemptmeter : MonoBehaviour
{
    int attempts;
    public Text attemptbar;


    private void Awake()
    {
        attempts = PlayerPrefs.GetInt("attempts");
        attempts++;
    }

    private void Start()
    {
        
        attemptbar.text = attempts.ToString();
        PlayerPrefs.SetInt("attempts", attempts);
    }
}
