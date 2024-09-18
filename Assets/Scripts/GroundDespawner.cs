using System;
using UnityEngine;

public class GroundDespawner : MonoBehaviour
{
    public static event Action<Transform> OnGroundTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("GroundTrigger")) return;

        OnGroundTrigger?.Invoke(collision.transform);
    }
}
