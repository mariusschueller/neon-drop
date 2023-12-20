﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud9 : MonoBehaviour
{

    float dirX, moveSpeed = 6f;
    bool moveRight = true;
    private float moveDistance;
    private float moveDistanceNegative;

    private void Start()
    {
        moveDistance = 6.5f;
        moveDistanceNegative = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > moveDistance)
            moveRight = false;
        if (transform.position.x < moveDistanceNegative)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}

