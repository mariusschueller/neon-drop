using UnityEngine;

public class camera_follow : MonoBehaviour {

    public Transform target;


    public float smoothSpeed = 0.125f;// the higher the value the faster it will lock on to the target
    public Vector3 offset;
    int pause;


    private void Update()
    {
        pause = PlayerPrefs.GetInt("started");
        if (pause == 1)
            transform.position = target.position + offset;
    }

    
}
