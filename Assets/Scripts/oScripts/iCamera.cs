using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iCamera : MonoBehaviour {

    public Transform iball;
    public Transform target;
    int ibegin;

    public float smoothSpeed = 0.125f;// the higher the value the faster it will lock on to the target
    public Vector3 offset;
    public Vector3 ioffset;

    private void Start()
    {
        ibegin = PlayerPrefs.GetInt("ibegin");
    }
    private void LateUpdate()
    {
        if (ibegin == 1)
        transform.position = iball.position + ioffset;

        else
            transform.position = target.position + offset;



    }
}