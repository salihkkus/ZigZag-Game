using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject Last_Ground;
    void Start()
    {
        for(int i = 0; i < 10 ; i++)
        {
            Spawn_Create();  
        }
    }

    void Spawn_Create()
    {
        Vector3 Aspect;

    if(Random.Range(0,2) == 0)
    {
        Aspect = Vector3.left;
    }
    else
    {
        Aspect = Vector3.forward;
    }

        Last_Ground = Instantiate(Last_Ground, Last_Ground.transform.position + Aspect, transform.rotation);
    }
}
