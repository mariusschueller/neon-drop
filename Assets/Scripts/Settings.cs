using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    int playMusic;
    public GameObject setting;
    public GameObject music;
    public GameObject playbutton;
    public GameObject stopbutton;

	
	void Awake () {
        setting.SetActive(false);

        playMusic = PlayerPrefs.GetInt("playMusic");

    }

    private void Update ()
    {
        if (playMusic == 1)
            BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }



    public void showvolume()
    {
        setting.SetActive(true);
        if (playMusic == 0)
            stopbutton.SetActive(true);
        if (playMusic == 1)
            playbutton.SetActive(true);
    }

    public void novolume()
    {
        setting.SetActive(false);
    }

    public void stopMusic()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        playbutton.SetActive(true);
        stopbutton.SetActive(false);
        playMusic = 1;
        PlayerPrefs.SetInt("playMusic", 1);
    }

    public void resumeMusic()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().UnPause();
        playbutton.SetActive(false);
        stopbutton.SetActive(true);
        playMusic = 0;
        PlayerPrefs.SetInt("playMusic", 0);

    }

}
