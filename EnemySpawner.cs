using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRangeX = 10f;
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;

    void Start()
    {
        // This repeatedly calls the SpawnEnemy function
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Generate a random position on the X axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, transform.position.z);

        // Requirement: Spawning GameObjects at runtime
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }
}