using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    private PlayerHealth playerHealth;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {   
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player takes " + damage + " points of damage!");
            playerHealth.TakeDamage(damage);
        }

    }
}
