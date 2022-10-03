using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score; //Store the Score value

    public TextMeshProUGUI scoreText; //Reference visual text UI to change

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseScore(int amount)
    {
        score += amount; //Add to the total score
        UpdateScoreText(); //Update the UI text
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; //Subtract from the total score
        UpdateScoreText(); //Update the UI text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
