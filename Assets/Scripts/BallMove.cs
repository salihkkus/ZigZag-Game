using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 aspect;
    public float speed;
    void Start()
    {
        aspect = Vector3.forward;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(aspect.x == 0)
            {
                aspect = Vector3.left;
            }
            else
            {
                aspect = Vector3.forward;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector3 Move = aspect * Time.deltaTime * speed;
        transform.position += Move;
    }
}
