using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{

    public float moveSpeed; //Speed tthe balloon will move upwards
    public float upperBound; // Top boundary in which the balloons can exist


    private Balloon balloon;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move balloon upwards
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        //Destroy balloon if it passes the top boundary
        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
