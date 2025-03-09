using UnityEngine;

public class LettersMover : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rigid_body;
    public Vector2 movement;
    void Start()
    {
        rigid_body = GetComponent<Rigidbody2D>();
        rigid_body.linearVelocity = movement * speed;
    }

    void Update()
    {
        if (transform.position.x < -12 || transform.position.y < -12) {
            Destroy(gameObject);
        }
    }
    
    void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 movement) {
        
    }
}
