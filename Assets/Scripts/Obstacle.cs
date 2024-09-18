using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("ObstacleTrigger")) return;

        gameObject.SetActive(false);
    }
}
