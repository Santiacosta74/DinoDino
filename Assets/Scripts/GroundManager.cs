using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private Transform spawnPoint;

    private void DespawnGround(Transform objToDespawn)
    {
        Destroy(objToDespawn.parent.gameObject);
        SpawnGround();
    }

    private void SpawnGround()
    {
        Instantiate(groundPrefab, spawnPoint.position, Quaternion.identity);
    }

    private void OnEnable()
    {
        GroundDespawner.OnGroundTrigger += DespawnGround;
    }

    private void OnDisable()
    {
        GroundDespawner.OnGroundTrigger -= DespawnGround;
    }
}
