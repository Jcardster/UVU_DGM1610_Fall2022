using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private ScoreManager scoreManager; //Variable to hold the reference to the ScoreManager
    public int scoreToGive;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Reference the ScoreManager
    }

    void OnTriggerEnter(Collider other)
    {

        scoreManager.IncreaseScore(scoreToGive); //Increase score amount by scoreToGive
        Destroy(other.gameObject); //Destroy the other game object
        Destroy(gameObject); //Destroy this game object
        
    }

}
