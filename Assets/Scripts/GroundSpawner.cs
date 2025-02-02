using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject Last_Ground;
    void Update()
    {
        for(int i = 0; i < 10 ; i++)
        {
            Spawn_Create();
        }
    }

    void Spawn_Create()
    {
    Last_Ground = Instantiate(Last_Ground, Last_Ground.transform.position + Vector3.forward, transform.rotation);
    }
}
