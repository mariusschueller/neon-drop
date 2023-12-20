using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attemptWin : MonoBehaviour
{
    public Text attemptScore;
    int attempts;
    void Awake()
    {
        attempts = PlayerPrefs.GetInt("attempts");
        attemptScore.text = attempts.ToString();
    }

    private void Start()
    {
        PlayerPrefs.SetInt("attempts", 0);
    }


}
