using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OShopControl : MonoBehaviour
{

    int moneyAmount;
    int isOSold;

    public Text moneyAmountText;
    public Text riflePrice;

    public Button buyButton;
    public Button orangeBuyButton;

    // Use this for initialization
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {

        moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

        isOSold = PlayerPrefs.GetInt("IsOSold");

        if (moneyAmount >= 5 && isOSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
    }

    public void buyRifle()
    {
        moneyAmount -= 5;
        PlayerPrefs.SetInt("IsOSold", 1);
        riflePrice.text = "Confirmed";
        buyButton.gameObject.SetActive(false);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("GameScene");
    }

    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        riflePrice.text = "Price: 5$";
        PlayerPrefs.DeleteAll();
    }




}
