using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testShopControl : MonoBehaviour {

    int moneyAmount;
    public Text moneyAmountText;



    int isRifleSold;
    public Text riflePrice;
    public Button buyButton;



    int oisRifleSold;
    public Text oriflePrice;
    public Button obuyButton;



    int yisRifleSold;
    public Text yriflePrice;
    public Button ybuyButton;



    int gisRifleSold;
    public Text griflePrice;
    public Button gbuyButton;




    int bisRifleSold;
    public Text briflePrice;
    public Button bbuyButton;




    int iisRifleSold;
    public Text iriflePrice;
    public Button ibuyButton;




    int visRifleSold;
    public Text vriflePrice;
    public Button vbuyButton;




    int rbegin;
    int obegin;
    int ybegin;
    int gbegin;
    int bbegin;
    int ibegin;
    int vbegin;


    public GameObject rSelect;
    public GameObject oSelect;
    public GameObject ySelect;
    public GameObject gSelect;
    public GameObject bSelect;
    public GameObject iSelect;
    public GameObject vSelect;


    int rtrigger;
    int otrigger;
    int ytrigger;
    int gtrigger;
    int btrigger;
    int itrigger;
    int vtrigger;

    public Button rplay;
    public Button oplay;
    public Button yplay;
    public Button gplay;
    public Button bplay;
    public Button iplay;
    public Button vplay;

    public Button final;

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("practice", 0);


        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

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


        rtrigger = 0;
        otrigger = 0;
        ytrigger = 0;
        gtrigger = 0;
        btrigger = 0;
        itrigger = 0;
        vtrigger = 0;

        
    }

    // Update is called once per frame
    void Update()
    {

        moneyAmountText.text = " " + moneyAmount.ToString();
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

        isRifleSold = PlayerPrefs.GetInt("IsRifleSold");
        oisRifleSold = PlayerPrefs.GetInt("oisRifleSold");
        yisRifleSold = PlayerPrefs.GetInt("yisRifleSold");
        gisRifleSold = PlayerPrefs.GetInt("gisRifleSold");
        bisRifleSold = PlayerPrefs.GetInt("bisRifleSold");
        iisRifleSold = PlayerPrefs.GetInt("iisRifleSold");
        visRifleSold = PlayerPrefs.GetInt("visRifleSold");



        if (isRifleSold == 1)
            riflePrice.text = "owned";
        if (oisRifleSold == 1)
            oriflePrice.text = "owned";
        if (yisRifleSold == 1)
            yriflePrice.text = "owned";
        if (gisRifleSold == 1)
            griflePrice.text = "owned";
        if (bisRifleSold == 1)
            briflePrice.text = "owned";
        if (iisRifleSold == 1)
            iriflePrice.text = "owned";
        if (visRifleSold == 1)
            vriflePrice.text = "owned";



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


        if (moneyAmount >= 640 && gisRifleSold == 0)
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


        if (moneyAmount >= 10240 && visRifleSold == 0)
            vbuyButton.interactable = true;
        else
            vbuyButton.interactable = false;




        if (isRifleSold == 1 && rtrigger == 1)
            rSelect.SetActive(true);
        else
            rSelect.SetActive(false);
   
        if (oisRifleSold == 1 && otrigger == 1)
            oSelect.SetActive(true);
        else
            oSelect.SetActive(false);

        if (yisRifleSold == 1 && ytrigger == 1)
            ySelect.SetActive(true);
        else
            ySelect.SetActive(false);

        if (gisRifleSold == 1 && gtrigger == 1)
            gSelect.SetActive(true);
        else
            gSelect.SetActive(false);

        if (bisRifleSold == 1 && btrigger == 1)
            bSelect.SetActive(true);
        else
            bSelect.SetActive(false);

        if (iisRifleSold == 1 && itrigger == 1)
            iSelect.SetActive(true);
        else
            iSelect.SetActive(false);

        if (visRifleSold == 1 && vtrigger == 1)
            vSelect.SetActive(true);
        else
            vSelect.SetActive(false);

        //BUTTON INTERACTABILITY HERE
        if (rtrigger == 1 && isRifleSold == 1)
            rplay.gameObject.SetActive(true);
        if (rtrigger == 0)
            rplay.gameObject.SetActive(false);
        if (isRifleSold == 0)
            rplay.gameObject.SetActive(false);

        if (otrigger == 1 && oisRifleSold == 1)
            oplay.gameObject.SetActive(true);
        if (otrigger == 0)
            oplay.gameObject.SetActive(false);
        if (oisRifleSold == 0)
            oplay.gameObject.SetActive(false);

        if (ytrigger == 1 && yisRifleSold == 1)
            yplay.gameObject.SetActive(true);
        if (ytrigger == 0)
            yplay.gameObject.SetActive(false);
        if (yisRifleSold == 0)
            yplay.gameObject.SetActive(false);

        if (gtrigger == 1 && gisRifleSold == 1)
            gplay.gameObject.SetActive(true);
        if (gtrigger == 0)
            gplay.gameObject.SetActive(false);
        if (gisRifleSold == 0)
            gplay.gameObject.SetActive(false);

        if (btrigger == 1 && bisRifleSold == 1)
            bplay.gameObject.SetActive(true);
        if (btrigger == 0)
            bplay.gameObject.SetActive(false);
        if (bisRifleSold == 0)
            bplay.gameObject.SetActive(false);

        if (itrigger == 1 && iisRifleSold == 1)
            iplay.gameObject.SetActive(true);
        if (itrigger == 0)
            iplay.gameObject.SetActive(false);
        if (iisRifleSold == 0)
            iplay.gameObject.SetActive(false);

        if (vtrigger == 1 && visRifleSold == 1)
            vplay.gameObject.SetActive(true);
        if (vtrigger == 0)
            vplay.gameObject.SetActive(false);
        if (visRifleSold == 0)
            vplay.gameObject.SetActive(false);


        if (isRifleSold == 1 && oisRifleSold == 1 && yisRifleSold == 1 && gisRifleSold == 1 && bisRifleSold == 1 && iisRifleSold == 1 && visRifleSold == 1)
            final.gameObject.SetActive(true);

    }



    public void freeRifle()
    {
        moneyAmount += 1000;
    }

    public void buyRifle()
    {
        moneyAmount -= 80;
        PlayerPrefs.SetInt("IsRifleSold", 1);
        buyButton.gameObject.SetActive(false);
    }

    public void obuyRifle()
    {
        moneyAmount -= 160;
        PlayerPrefs.SetInt("oisRifleSold", 1);
        obuyButton.gameObject.SetActive(false);
    }

    public void ybuyRifle()
    {
        moneyAmount -= 320;
        PlayerPrefs.SetInt("yisRifleSold", 1);
        ybuyButton.gameObject.SetActive(false);
    }

    public void gbuyRifle()
    {
        moneyAmount -= 640;
        PlayerPrefs.SetInt("gisRifleSold", 1);
        gbuyButton.gameObject.SetActive(false);
    }

    public void bbuyRifle()
    {
        moneyAmount -= 1280;
        PlayerPrefs.SetInt("bisRifleSold", 1);
        bbuyButton.gameObject.SetActive(false);
    }

    public void ibuyRifle()
    {
        moneyAmount -= 2560;
        PlayerPrefs.SetInt("iisRifleSold", 1);
        ibuyButton.gameObject.SetActive(false);
    }

    public void vbuyRifle()
    {
        moneyAmount -= 10240;
        PlayerPrefs.SetInt("visRifleSold", 1);
        vbuyButton.gameObject.SetActive(false);
    }



    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("rStageSelect");
    }


    public void rTrigger()
    {
        rtrigger = 1;
        otrigger = 0;
        ytrigger = 0;
        gtrigger = 0;
        btrigger = 0;
        itrigger = 0;
        vtrigger = 0;
    }

    public void oTrigger()
    {
        rtrigger = 0;
        otrigger = 1;
        ytrigger = 0;
        gtrigger = 0;
        btrigger = 0;
        itrigger = 0;
        vtrigger = 0;
    }

    public void yTrigger()
    {
        rtrigger = 0;
        otrigger = 0;
        ytrigger = 1;
        gtrigger = 0;
        btrigger = 0;
        itrigger = 0;
        vtrigger = 0;
    }

    public void gTrigger()
    {
        rtrigger = 0;
        otrigger = 0;
        ytrigger = 0;
        gtrigger = 1;
        btrigger = 0;
        itrigger = 0;
        vtrigger = 0;
    }

    public void bTrigger()
    {
        rtrigger = 0;
        otrigger = 0;
        ytrigger = 0;
        gtrigger = 0;
        btrigger = 1;
        itrigger = 0;
        vtrigger = 0;
    }

    public void iTrigger()
    {
        rtrigger = 0;
        otrigger = 0;
        ytrigger = 0;
        gtrigger = 0;
        btrigger = 0;
        itrigger = 1;
        vtrigger = 0;
    }

    public void vTrigger()
    {
        rtrigger = 0;
        otrigger = 0;
        ytrigger = 0;
        gtrigger = 0;
        btrigger = 0;
        itrigger = 0;
        vtrigger = 1;
    }


    //SCENE CHANGERS HERE
    public void rStageSelect()
    {

        SceneManager.LoadScene("rStageSelect");
    }

    public void oStageSelect()
    {

        SceneManager.LoadScene("oStageSelect");
    }

    public void yStageSelect()
    {

        SceneManager.LoadScene("yStageSelect");
    }

    public void gStageSelect()
    {

        SceneManager.LoadScene("gStageSelect");
    }

    public void bStageSelect()
    {

        SceneManager.LoadScene("bStageSelect");
    }

    public void iStageSelect()
    {

        SceneManager.LoadScene("iStageSelect");
    }

    public void vStageSelect()
    {

        SceneManager.LoadScene("vStageSelect");
    }

    public void StageSelect()
    {

        SceneManager.LoadScene("StageSelect");
    }


    public void buyScene()
    {
        SceneManager.LoadScene("buyScene");
    }


    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        riflePrice.text = "Price: 80";
        PlayerPrefs.DeleteAll();
    }

}
