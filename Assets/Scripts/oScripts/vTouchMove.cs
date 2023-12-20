using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vTouchMove : MonoBehaviour {


    int Pause;

    void Update () {

        Pause = PlayerPrefs.GetInt("pause");

        if (Input.touchCount > 0 && Pause == 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = touchPosition;
        }
    }
}
