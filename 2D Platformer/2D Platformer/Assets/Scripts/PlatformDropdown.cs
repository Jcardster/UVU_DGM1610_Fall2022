using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropdown : MonoBehaviour
{

    public PlatformEffector2D effector2D;

    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //resets the wait time when key is released
     if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            waitTime = 0.5f;
        }
     //Flipping effector down
     if(Input.GetKey(KeyCode.DownArrow))
        {
            if(waitTime <=0)//if wait time is reduced to zero flip effector down
            {
                effector2D.rotationalOffset = 100f;//flips effector
                waitTime = 0.5f;//sets wait time
            }
            else
            {
                waitTime -= Time.deltaTime;// reduces wait time over time
            }

        }
     //flips effector back up
     if(Input.GetKey(KeyCode.Space))
        {
            effector2D.rotationalOffset = 0;
        }
    }
}
