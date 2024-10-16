using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    // Variables públicas ajustables
    public float speed = 5f;          // Velocidad de movimiento horizontal
    public float jumpForce = 10f;     // Fuerza del salto
    public LayerMask groundLayer;     // Capa que se considera como suelo
    public Transform groundCheck;     // Transform para detectar si el personaje está tocando el suelo
    public float groundCheckRadius = 0.1f; // Radio para la detección del suelo

    // Componentes
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    // Variables internas
    private bool isGrounded;
    private float velocidad;  // Velocidad horizontal actual del Rigidbody

    void Start()
    {
        // Obtener los componentes necesarios
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Actualizar si el personaje está tocando el suelo
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Actualizar el movimiento y la animación
        Move();
        UpdateAnimation();
    }

    void Move()
    {
        // Obtener la entrada horizontal del jugador (A/D o Flechas)
        float moveInput = Input.GetAxis("Horizontal");
        
        // Aplicar movimiento horizontal
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Obtener la velocidad actual del Rigidbody en el eje X
        velocidad = Mathf.Abs(rb.velocity.x);

        // Controlar el flip del sprite en función de la dirección
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false;  // Mirar hacia la derecha
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true;   // Mirar hacia la izquierda
        }

        // Saltar si está en el suelo y se presiona el botón de salto
        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void UpdateAnimation()
    {
        // Controlar la animación de salto
        if (isGrounded)
        {
            animator.SetBool("Grounded", true);
        }
        else
        {
            animator.SetBool("Grounded", false);
        }

        // Controlar la animación de correr basada en la velocidad horizontal
        animator.SetFloat("velocidad", velocidad);

    }

    // Dibujar un gizmo en la escena para visualizar el ground check
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
