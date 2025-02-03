using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Last_Ground;
    private Vector3 lastPosition;
    
    void Start()
    {
        lastPosition = Last_Ground.transform.position;

        for (int i = 0; i < 15; i++)
        {
            Spawn_Create();
        }
    }

    public void Spawn_Create()
    {
        Vector3 Aspect;

        if (Random.Range(0, 2) == 0)
        {
            Aspect = new Vector3(-1, 0, 0); // Sol tarafa ekleme
        }
        else
        {
            Aspect = new Vector3(0, 0, 1); // İleriye ekleme
        }

        lastPosition += Aspect; // Son pozisyonu güncelle

        Last_Ground = Instantiate(Last_Ground, lastPosition, Quaternion.identity);
    }
}
