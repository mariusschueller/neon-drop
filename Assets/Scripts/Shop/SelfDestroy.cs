using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour
{

    // Use this for initialization
    public void DestroyThisObject()
    {
        Destroy(gameObject);
    }
}
