using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;
    private bool isGrounded = true;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal"); 
        if (movement.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); 
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); 
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            Jump();
        }
        animator.SetFloat("Speed", Mathf.Abs(movement.x));

    }

    void FixedUpdate()
    {
        
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }
    void Jump()
    {
        
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false; 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
