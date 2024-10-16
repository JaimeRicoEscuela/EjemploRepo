using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        // Obtener la referencia al componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();

        // Aplicar una fuerza hacia la derecha
        Vector2 force = new Vector2(10f, 0f);
        rb.AddTorque(8.2f);  // Opcionalmente, puedes definir el ForceMode2D
    }
}
