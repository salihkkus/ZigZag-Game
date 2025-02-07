using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ballplace; // Reference to the ball's transform
    Vector3 diff; // Stores the initial offset between the camera and the ball

    void Start()
    {
        diff = transform.position - ballplace.position; // Calculate the initial offset
    }

    void Update()
    {
        if (BallMove.fall == false) // Check if the ball has not fallen
        {
            transform.position = diff + ballplace.position; // Maintain the initial offset while following the ball
        }
    }
}
