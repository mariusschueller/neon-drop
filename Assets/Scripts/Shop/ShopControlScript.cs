using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
    public Text moneyAmountText;



    int isRifleSold;
	public Text riflePrice;
    public Button buyButton;
    public Button rplay;


    int oisRifleSold;
    public Text oriflePrice;
    public Button obuyButton;
    public Button oplay;


    int yisRifleSold;
    public Text yriflePrice;
    public Button ybuyButton;
    public Button yplay;


    int gisRifleSold;
    public Text griflePrice;
    public Button gbuyButton;
    public Button gplay;



    int bisRifleSold;
    public Text briflePrice;
    public Button bbuyButton;
    public Button bplay;



    int iisRifleSold;
    public Text iriflePrice;
    public Button ibuyButton;
    public Button iplay;



    int visRifleSold;
    public Text vriflePrice;
    public Button vbuyButton;
    public Button vplay;



    int rbegin;
    int obegin;
    int ybegin;
    int gbegin;
    int bbegin;
    int ibegin;
    int vbegin;




    // Use this for initialization
    void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");

        rbegin = PlayerPrefs.GetInt("rbegin");
        obegin = PlayerPrefs.GetInt("obegin");
        ybegin = PlayerPrefs.GetInt("ybegin");
        gbegin = PlayerPrefs.GetInt("gbegin");
        bbegin = PlayerPrefs.GetInt("bbegin");
        ibegin = PlayerPrefs.GetInt("ibegin");
        vbegin = PlayerPrefs.GetInt("vbegin");


        PlayerPrefs.SetInt("rbegin", 0);
        PlayerPrefs.SetInt("obegin", 0);
        PlayerPrefs.SetInt("ybegin", 0);
        PlayerPrefs.SetInt("gbegin", 0);
        PlayerPrefs.SetInt("bbegin", 0);
        PlayerPrefs.SetInt("ibegin", 0);
        PlayerPrefs.SetInt("vbegin", 0);



    }

    // Update is called once per frame
    void Update () {
		
		moneyAmountText.text = " " + moneyAmount.ToString();

		isRifleSold = PlayerPrefs.GetInt ("IsRifleSold");
        oisRifleSold = PlayerPrefs.GetInt("oisRifleSold");
        yisRifleSold = PlayerPrefs.GetInt("yisRifleSold");
        gisRifleSold = PlayerPrefs.GetInt("gisRifleSold");
        bisRifleSold = PlayerPrefs.GetInt("bisRifleSold");
        iisRifleSold = PlayerPrefs.GetInt("iisRifleSold");
        visRifleSold = PlayerPrefs.GetInt("visRifleSold");



        //MAKE SURE YOU CHANGE THE MONEY AMOUNT


        //DO NOT FORGET
        if (moneyAmount >= 80 && isRifleSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;	


        if (moneyAmount >= 160 && oisRifleSold == 0)
            obuyButton.interactable = true;
        else
            obuyButton.interactable = false;
       

        if (moneyAmount >= 320 && yisRifleSold == 0)
            ybuyButton.interactable = true;
        else
            ybuyButton.interactable = false;


        if (moneyAmount >= 640 && gisRifleSold ==0)
            gbuyButton.interactable = true;
        else
            gbuyButton.interactable = false;


        if (moneyAmount >= 1280 && bisRifleSold == 0)
            bbuyButton.interactable = true;
        else
            bbuyButton.interactable = false;


        if (moneyAmount >= 2560 && iisRifleSold == 0)
            ibuyButton.interactable = true;
        else
            ibuyButton.interactable = false;


        if (moneyAmount >= 5120 && visRifleSold == 0)
            vbuyButton.interactable = true;
        else
            vbuyButton.interactable = false;




        //BUTTON INTERACTABILITY HERE
        if (isRifleSold == 1)
            rplay.interactable = true;
        else
            rplay.interactable = false;



        if (oisRifleSold == 1)
            oplay.interactable = true;
        else
            oplay.interactable = false;



        if (yisRifleSold == 1)
            yplay.interactable = true;
        else
            yplay.interactable = false;


        if (gisRifleSold == 1)
            gplay.interactable = true;
        else
            gplay.interactable = false;


        if (bisRifleSold == 1)
            bplay.interactable = true;
        else
            bplay.interactable = false;


        if (iisRifleSold == 1)
            iplay.interactable = true;
        else
            iplay.interactable = false;


        if (visRifleSold == 1)
            vplay.interactable = true;
        else
            vplay.interactable = false;
    }


    public void freeRifle()
    {
        moneyAmount += 100;
    }

    public void buyRifle()
	{
		moneyAmount -= 80;
		PlayerPrefs.SetInt ("IsRifleSold", 1);
		riflePrice.text = "yay";
		buyButton.gameObject.SetActive (false);
	}

    public void obuyRifle()
    {
        moneyAmount -= 160;
        PlayerPrefs.SetInt("oisRifleSold", 1);
        oriflePrice.text = "yay";
        obuyButton.gameObject.SetActive(false);
    }

    public void ybuyRifle()
    {
        moneyAmount -= 320;
        PlayerPrefs.SetInt("yisRifleSold", 1);
        yriflePrice.text = "yay";
        ybuyButton.gameObject.SetActive(false);
    }

    public void gbuyRifle()
    {
        moneyAmount -= 640;
        PlayerPrefs.SetInt("gisRifleSold", 1);
        griflePrice.text = "yay";
        gbuyButton.gameObject.SetActive(false);
    }

    public void bbuyRifle()
    {
        moneyAmount -= 1280;
        PlayerPrefs.SetInt("bisRifleSold", 1);
        briflePrice.text = "yay";
        bbuyButton.gameObject.SetActive(false);
    }

    public void ibuyRifle()
    {
        moneyAmount -= 2560;
        PlayerPrefs.SetInt("iisRifleSold", 1);
        iriflePrice.text = "yay";
        ibuyButton.gameObject.SetActive(false);
    }

    public void vbuyRifle()
    {
        moneyAmount -= 5120;
        PlayerPrefs.SetInt("visRifleSold", 1);
        vriflePrice.text = "yay";
        vbuyButton.gameObject.SetActive(false);
    }



    public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("rStageSelect");
	}




    public void rStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("rStageSelect");
    }

    public void oStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("oStageSelect");
    }

    public void yStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("yStageSelect");
    }

    public void gStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("gStageSelect");
    }

    public void bStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("bStageSelect");
    }

    public void iStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("iStageSelect");
    }

    public void vStageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("vStageSelect");
    }

    public void StageSelect()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("StageSelect");
    }


    public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		riflePrice.text = "Price: 80";
		PlayerPrefs.DeleteAll ();
	}

}
