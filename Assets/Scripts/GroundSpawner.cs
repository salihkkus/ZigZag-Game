using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Last_Ground; // The last spawned ground object
    private Vector3 lastPosition; // Stores the last position where a ground piece was placed
    
    void Start()
    {
        lastPosition = Last_Ground.transform.position; // Initialize last position with the first ground object

        for (int i = 0; i < 25; i++)
        {
            Spawn_Create(); // Spawn 25 ground pieces at the beginning
        }
    }

    public void Spawn_Create()
    {
        Vector3 Aspect; // Determines the direction of the next ground piece

        if (Random.Range(0, 2) == 0)
        {
            Aspect = new Vector3(-1, 0, 0); // Add to the left
        }
        else
        {
            Aspect = new Vector3(0, 0, 1); // Add forward
        }

        lastPosition += Aspect; // Update the last position

        Last_Ground = Instantiate(Last_Ground, lastPosition, Quaternion.identity); // Spawn a new ground piece at the updated position
    }
}
