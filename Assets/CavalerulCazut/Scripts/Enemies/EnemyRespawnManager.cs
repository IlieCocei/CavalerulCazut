using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 10f;
    private float nextRespawnTime = 0f;

    void Start()
    {
        // La început, spawnează primii 5 inamici.
        SpawnNewEnemies(5);
    }

    void Update()
    {
        // Verifică dacă toți inamicii au fost eliminați și dacă timpul pentru respawn a sosit.
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && Time.time >= nextRespawnTime)
        {
            // Crește numărul maxim de inamici cu 5.
            int currentMaxEnemies = GameObject.FindGameObjectsWithTag("EnemyRespawn").Length;
            SpawnNewEnemies(currentMaxEnemies + 5);

            // Planifică respawn-ul următor după intervalul specificat.
            nextRespawnTime = Time.time + respawnTime;
        }
    }

    void SpawnNewEnemies(int numEnemies)
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}