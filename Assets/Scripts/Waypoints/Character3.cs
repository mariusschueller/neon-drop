using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character3 : MonoBehaviour
{

    public float speed;
    private Waypoints3 Wpoints3;

    private int waypointIndex;

    void Start()
    {
        Wpoints3 = GameObject.FindGameObjectWithTag("Waypoints3").GetComponent<Waypoints3>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints3.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoints3.waypoints[waypointIndex].position) < 0.1f)
        {
            waypointIndex++;
            if (waypointIndex < Wpoints3.waypoints.Length - 1)
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
