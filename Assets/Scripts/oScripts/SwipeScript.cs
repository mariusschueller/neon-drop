using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    private Rigidbody2D rb;

    private float verticleSpeed;



    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        verticleSpeed = -13.5f;
    }

    int lastFingerId = -1;
    private void Update()
    {

        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 10 && touch.position.y < Screen.height * .7)
                        rb.velocity = new Vector2(-14, verticleSpeed);

                    if (touch.position.x < 2 * Screen.width / 10 && touch.position.x > 1 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-11, verticleSpeed);

                    if (touch.position.x < 3 * Screen.width / 10 && touch.position.x > 2 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-8, verticleSpeed);

                    if (touch.position.x < 4 * Screen.width / 10 && touch.position.x > 3 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-5, verticleSpeed);

                    if (touch.position.x < 5 * Screen.width / 10 && touch.position.x > 4 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-2, verticleSpeed);

                    if (touch.position.x < 6 * Screen.width / 10 && touch.position.x > 5 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(2, verticleSpeed);

                    if (touch.position.x < 7 * Screen.width / 10 && touch.position.x > 6 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(5, verticleSpeed);

                    if (touch.position.x < 8 * Screen.width / 10 && touch.position.x > 7 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(8, verticleSpeed);

                    if (touch.position.x < 9 * Screen.width / 10 && touch.position.x > 8 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(11, verticleSpeed);

                    if (touch.position.x > 9 * Screen.width / 10 && touch.position.y < Screen.height * .7)
                        rb.velocity = new Vector2(14, verticleSpeed);

                    lastFingerId = touch.fingerId;
                    break;

                

                case TouchPhase.Moved:
                    if (touch.position.x < Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-14, verticleSpeed);

                    if (touch.position.x < 2 * Screen.width / 10 && touch.position.x > 1 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-11, verticleSpeed);

                    if (touch.position.x < 3 * Screen.width / 10 && touch.position.x > 2 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-8, verticleSpeed);

                    if (touch.position.x < 4 * Screen.width / 10 && touch.position.x > 3 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-5, verticleSpeed);

                    if (touch.position.x < 5 * Screen.width / 10 && touch.position.x > 4 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(-2, verticleSpeed);

                    if (touch.position.x < 6 * Screen.width / 10 && touch.position.x > 5 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(2, verticleSpeed);

                    if (touch.position.x < 7 * Screen.width / 10 && touch.position.x > 6 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(5, verticleSpeed);

                    if (touch.position.x < 8 * Screen.width / 10 && touch.position.x > 7 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(8, verticleSpeed);

                    if (touch.position.x < 9 * Screen.width / 10 && touch.position.x > 8 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(11, verticleSpeed);

                    if (touch.position.x > 9 * Screen.width / 10 && touch.position.y < Screen.height * .8)
                        rb.velocity = new Vector2(14, verticleSpeed);
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
