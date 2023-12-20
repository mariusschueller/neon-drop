using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yTouchMover : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed;
    private float verticleSpeed;
    int destroyY;
    int starti;



    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 9.9f;
        verticleSpeed = -13.5f;
        starti = 0;
        destroyY = 0;
        
    }

    int lastFingerId = -1;
    private void Update()
    {
       

        if (starti < 5)
            starti++;

        destroyY = PlayerPrefs.GetInt("destroyY");

        if (destroyY == 1)
            transform.gameObject.tag = "YellowD";
        if (destroyY >= 1)
            destroyY++;
        if (destroyY == 30)
            transform.gameObject.tag = "Player";
        if (destroyY == 30)
            destroyY = -1;



            foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 3 && touch.position.y < Screen.height * .7 && starti == 5)
                        rb.velocity = new Vector2(-moveSpeed, verticleSpeed);
                    if (touch.position.x > 2 * Screen.width / 3 && touch.position.y < Screen.height * .7 && starti == 5)
                        rb.velocity = new Vector2(moveSpeed, verticleSpeed);
                    if (touch.position.x < 2 * Screen.width / 3 && touch.position.x > Screen.width / 3 && touch.position.y < Screen.height * .8 && destroyY == 0)
                        destroyY = 1;
                        lastFingerId = touch.fingerId;
                    break;

                case TouchPhase.Ended:
                    if (touch.fingerId == lastFingerId)
                        rb.velocity = new Vector2(0f, verticleSpeed);

                    break;
            }
        }
    }
}
