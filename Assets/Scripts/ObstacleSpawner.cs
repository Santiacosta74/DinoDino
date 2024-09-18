using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float spawnObstacleCooldown;
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0f, spawnObstacleCooldown);
    }

    private void SpawnObstacle()
    {
        GameObject obs = PoolManager.Instance.GetPooledObject();

        obs.transform.position = spawnPoint.position;
        obs.SetActive(true);
    }
}
