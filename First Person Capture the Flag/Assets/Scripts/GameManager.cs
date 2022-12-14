using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Flags Stats")]
    public bool hasFlag;
    public bool flagPlaced;

    // Start is called before the first frame update
    void Start()
    {
        //Flag bools
        hasFlag = false;
        flagPlaced = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(flagPlaced)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You've Won the Game!");
        Time.timeScale = 0; //Freeze the Game
    }

    public void PlaceFlag()
    {
        flagPlaced = true;
    }
}
