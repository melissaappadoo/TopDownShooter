using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject prefab;

    public float delay = 0.25f;
    private float counter = 0;

    private void Update()
    {
        counter += Time.deltaTime;

        if (counter >= delay)
        {
            counter = 0;

            SpawnEnemy(player, prefab);
        }
    }

    public void SpawnEnemy(GameObject player, GameObject prefab)
    {
        float enemySpawnRadius = 2.0f;

        Vector3 playerPos = player.transform.position;

        Vector3 spawnPos = playerPos + (Vector3)Random.insideUnitCircle.normalized * enemySpawnRadius;

        Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
