using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3; //How many clicks are required to pop
    public float scaleToIncrease = .10f; //How much the 0bject will scale
    public int scoreToGive = 100;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component.
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1;

        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            //Send points to score manager and update score
            scoreManager.IncreaseScoreText(scoreToGive);
            //Destroy Balloon
            Destroy(gameObject);
        }
    }

}
