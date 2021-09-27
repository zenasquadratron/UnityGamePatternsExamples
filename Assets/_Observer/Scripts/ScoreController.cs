using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        AdjustScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustScore(int value)
    {
        currentScore += value;
        scoreText.text = currentScore.ToString();
    }
}
