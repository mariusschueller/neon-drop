using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyMoney : MonoBehaviour {

    int moneyAmount;
    public Text moneyAmountText;


    private void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    private void Update()
    {
        moneyAmountText.text = " " + moneyAmount.ToString();
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }
    // Use this for initialization
    public void buytier1()
    {
        moneyAmount += 100;
    }

}
