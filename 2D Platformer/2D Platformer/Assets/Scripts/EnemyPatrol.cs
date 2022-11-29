using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public float speed; //How fast the enemy moves
    public float rayDistance; //How far the ray extends
    private bool isMovingRight = true; //Is the enemy moving right
    public Transform groundDetection; //Is the enemy touching the ground


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Move enemy to the right

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance); //Raycasting - prodes a ray from an origin point in a certain direction with a set distance
        if(groundInfo.collider == false)
        {
            if(isMovingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0); //Flip enemy at edge to move left
                isMovingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0); //Flip enemy at edge to move right
                isMovingRight = true;
            }
        }
    }
}
