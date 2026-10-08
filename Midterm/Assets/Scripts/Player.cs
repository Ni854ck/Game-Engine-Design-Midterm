using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int health = 5;
    [SerializeField] private float moveSpeed = 6f;
    [SerializeField] private float jumpForce = 4f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rigidbody;
    private float horizontalInput;
    private bool isGrounded;

    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x, jumpForce);
        }
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(horizontalInput * moveSpeed, rigidbody.linearVelocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 5;

            if (health <= 0)
            {
                //Die();
            }
        }
    }
}