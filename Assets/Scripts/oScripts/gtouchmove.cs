using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gtouchmove : MonoBehaviour
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
        starti = 0;
    }

    int lastFingerId = -1;
    private void Update()
    {
        if (starti < 5)
            starti++;
        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 3 && touch.position.y < Screen.height * .7 && starti == 5)
                        rb.velocity = new Vector2(-moveSpeed, verticleSpeed);
                    if (touch.position.x > 2 * Screen.width / 3 && touch.position.y < Screen.height * .7 && starti == 5)
                        rb.velocity = new Vector2(moveSpeed, verticleSpeed);
                    if (touch.position.x < 2 * Screen.width / 3 && touch.position.x > Screen.width / 3 && touch.position.y < Screen.height * .8)
                        rb.AddForce(new Vector2(0f, 1500f), ForceMode2D.Force);
                    lastFingerId = touch.fingerId;
                    break;
                case TouchPhase.Ended:
                    if (touch.fingerId == lastFingerId)
                        rb.velocity = new Vector2(0f, verticleSpeed); //if it still resets the speed put -20
                    break;
            }
        }
    }
}
