using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health: " + currentHealth);

        if(currentHealth <= 0)
        {
            Debug.Log("Your are dead! Game Over!"); //Console death message
            Time.timeScale = 0; //Freeze game
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth) //Puts cap on current health amount
        {
            currentHealth = maxHealth;
        }
    }
}
