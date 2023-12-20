using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {

	public Text moneyText;
	public static int moneyAmount;
	int isRifleSold;
    int oisRifleSold;
    public GameObject rifle;
    public GameObject original;
    public GameObject orange;

    // Use this for initialization
    void Start() {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        isRifleSold = PlayerPrefs.GetInt("IsRifleSold");
        oisRifleSold = PlayerPrefs.GetInt("oisRifleSold");


        if (isRifleSold == 1)
            rifle.SetActive(true);
       
		else
			rifle.SetActive (false);

        if (isRifleSold == 1)
            original.SetActive(false);

        else
        original.SetActive(true);

        if (oisRifleSold == 1)
            original.SetActive(false);

        else
            original.SetActive(true);

        if (oisRifleSold == 1)
            orange.SetActive(true);

        else
            orange.SetActive(false);


    }
  
	// Update is called once per frame
	void Update () {
		moneyText.text = "Money: " + moneyAmount.ToString();


	}

	public void RedShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("Red Shop");
	}
}
