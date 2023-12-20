using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ydestroy : MonoBehaviour
{
    int frame;
    int destroyY;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        frame = 0;
    }

    IEnumerator Example()
    {
        rb.velocity = new Vector2(0, 9);

        Destroy(gameObject, .2f);

        yield return new WaitUntil(() => frame >= 10);
        PlayerPrefs.SetInt("destroyY", 0);
    }

    void Update()
    {
        //Debug.Log("Frame: " + frame);
        //Debug.Log("DestroyY: " + destroyY);
        destroyY = PlayerPrefs.GetInt("destroyY");


        if (destroyY == 1)
        {
            StartCoroutine(Example());
            frame++;
        }
    }
}