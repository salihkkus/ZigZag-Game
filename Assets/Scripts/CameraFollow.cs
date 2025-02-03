using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ballplace;
    Vector3 diff;

    void Start()
    {
        diff = transform.position - ballplace.position;
    }

   
    void Update()
    {
        if(BallMove.fall == false)
        {
            transform.position = diff + ballplace.position;
        }
    }
}
