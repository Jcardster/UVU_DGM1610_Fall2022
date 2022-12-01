using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CandyManager : MonoBehaviour
{

    public static CandyManager instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int candyValue)
    {
        score += candyValue;
        text.text = "X" + score.ToString();
    }
}
