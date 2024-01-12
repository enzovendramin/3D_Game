using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypountIndex = 0;

    [SerializeField] float speed = 1f;
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypountIndex].transform.position) < .1f)
        {
            currentWaypountIndex++;
            if (currentWaypountIndex >= waypoints.Length)
            {
                currentWaypountIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypountIndex].transform.position, speed * Time.deltaTime);
    }
}
