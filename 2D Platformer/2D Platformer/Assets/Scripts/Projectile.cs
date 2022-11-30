using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 30f;
    public int damage = 10;
    public Rigidbody2D rb;
    public bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Reference the Rigidbody component 
        rb.velocity = transform.right * speed; //Adds velocity to the projectile
       
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        GhostEnemy enemy = other.GetComponent<GhostEnemy>();

        if (other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage); //Apply damage to enemy
        }

        Destroy(gameObject); //Destroys projectile
    }
}
