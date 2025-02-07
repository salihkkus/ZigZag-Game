using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scores; // Static variable to store the score
    public Text scoretext; // UI Text component to display the score
    
    void Start()
    {
        scores = 0; // Initialize the score to 0 at the start
    }

    void Update()
    {
        scoretext.text = scores.ToString(); // Update the score text in the UI every frame
    }
}
