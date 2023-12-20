using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed;
    private float verticleSpeed;
    int starti;



    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 9.9f;
        verticleSpeed = -13.5f;
        

    }

    int lastFingerId = -1;
    private void Update()
    {
        starti = PlayerPrefs.GetInt("started");
        

        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2 && touch.position.y < Screen.height * .7 && starti == 1)
                        rb.velocity = new Vector2(-moveSpeed, verticleSpeed);

                    if (touch.position.x > Screen.width / 2 && touch.position.y < Screen.height * .7 && starti == 1)
                        rb.velocity = new Vector2(moveSpeed, verticleSpeed);


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
