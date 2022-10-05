using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    
    private float spawnRangeX = 17.2f;
    [SerializeField]
    private float spawnPosZ;

    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); //Generate a position from which to spawn enemies
        int enemyIndex = Random.Range(0, enemyPrefabs.Length); //Pick a random UFO
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation); //Spawn the chosen UFO in the chosen position
    }
}
