using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void MoveCharacter(Vector2 direction)
    {
        _rb.linearVelocity = direction.normalized * speed;
    }
}
