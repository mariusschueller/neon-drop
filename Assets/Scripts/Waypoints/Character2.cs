using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : MonoBehaviour
{

    public float speed;
    private Waypoints2 Wpoints2;

    private int waypointIndex;

    void Start()
    {
        Wpoints2 = GameObject.FindGameObjectWithTag("Waypoints2").GetComponent<Waypoints2>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints2.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoints2.waypoints[waypointIndex].position) < 0.1f)
        {
            waypointIndex++;
            if (waypointIndex < Wpoints2.waypoints.Length - 1)
            {
                waypointIndex++;
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }
}
