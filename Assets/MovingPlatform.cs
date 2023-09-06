using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 pointA; // Starting point
    public Vector3 pointB; // Ending point
    public float speed = 1.0f; 

    private Vector3 target; // Target point for movement

    void Start()
    {

        target = pointB;
    }

    void Update()
    {
        // Move the platform towards the current target
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        
        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            // Swap the target
            target = (target == pointA) ? pointB : pointA;
        }
    }
}
