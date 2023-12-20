using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shopCamera : MonoBehaviour
{

    public Transform rtarget;
    public Transform otarget;
    public Transform ytarget;
    public Transform gtarget;
    public Transform btarget;

    int rbegin;
    int obegin;
    int ybegin;
    int gbegin;
    int bbegin;



    public float smoothSpeed = 0.125f;// the higher the value the faster it will lock on to the target
    public Vector3 offset;

    void Start()
    {
        rbegin = PlayerPrefs.GetInt("rbegin");
        obegin = PlayerPrefs.GetInt("obegin");
        ybegin = PlayerPrefs.GetInt("ybegin");
        gbegin = PlayerPrefs.GetInt("gbegin");
        bbegin = PlayerPrefs.GetInt("bbegin");

    }

        private void LateUpdate()
    {
        if (rbegin == 1)
            transform.position = rtarget.position + offset;

        if (obegin == 2)
            transform.position = otarget.position + offset;

        if (ybegin == 1)
            transform.position = ytarget.position + offset;

        if (gbegin == 1)
            transform.position = gtarget.position + offset;

        if (bbegin == 1)
            transform.position = btarget.position + offset;
    }
}
