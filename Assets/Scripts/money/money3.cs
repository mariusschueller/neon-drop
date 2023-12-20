using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class money3 : MonoBehaviour
{

    int practice;
    public Text moneyText;
    public static int moneyAmount;
    public GameObject plus;

    // Use this for initialization
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        practice = PlayerPrefs.GetInt("practice");
        if (practice == 0)
            moneyAmount = moneyAmount + 50;
        if (practice == 1)
            plus.SetActive(false);
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = " " + moneyAmount.ToString();
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }
}
