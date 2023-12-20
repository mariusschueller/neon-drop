using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testMove : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed;
    private float verticleSpeed;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 12.1f;
        verticleSpeed = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 3)
                        rb.velocity = new Vector2(-moveSpeed, verticleSpeed);
                    if (touch.position.x > 2 * Screen.width / 3)
                        rb.velocity = new Vector2(moveSpeed, verticleSpeed);
                   
                    break;

                case TouchPhase.Ended:
                    rb.velocity = new Vector2(0f, verticleSpeed); //if it still resets the speed put -20
                    break;
            }
        }
    }
}
