using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scores;
    public Text scoretext;
    void Start()
    {
        scores = 0;
    }

    
    void Update()
    {
        scoretext.text = scores.ToString();
    }
}
