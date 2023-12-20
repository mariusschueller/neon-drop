﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class showMoney : MonoBehaviour
{

    public Text moneyText;
    public static int moneyAmount;

    // Use this for initialization
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = " " + moneyAmount.ToString();
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }
}
