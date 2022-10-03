using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;

    private ScoreManager scoreManager;
    private DetectCollision detectCollision;


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();
    }

    void SAwake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollision.scoreToGive); //Decrease score when a ship passes
            //Debug.Log("Game Over!");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }




    }
}
