using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollcript : MonoBehaviour {

    float scrollSpeed = -30f;
    Vector2 startPos;
    // Use this for initialization
	void Start () {
        startPos = transform.position;
        Time.timeScale = 1f;

    }
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 350f);
        transform.position = startPos + Vector2.right * newPos;
	}
}
