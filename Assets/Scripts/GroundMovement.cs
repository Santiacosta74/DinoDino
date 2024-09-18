using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
    }
}
