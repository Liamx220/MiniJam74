using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2new : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    float nextSpawnTime;
    public Vector2 spawnSizeMinMax;
    public Vector2 secondsBetweenSpawnsMinMax;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float secondsBetweenSpawns = Mathf.Lerp (secondsBetweenSpawnsMinMax.y, secondsBetweenSpawnsMinMax.x, Difficulty.GetDifficultyPercent ());
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            int randomEnemy = Random.Range(0, enemyPrefabs.Length);
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            float spawnSize = Random.Range (spawnSizeMinMax.x, spawnSizeMinMax.y);

            Instantiate(enemyPrefabs[randomEnemy], spawnPoints[randomSpawnPoint].position, transform.rotation);
            
            
        }

    }
}
