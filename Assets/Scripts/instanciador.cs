using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform shootingPoint;
    public float launchForce = 500f;    // Fuerza del disparo

    void Start()
    {
        // Instanciar el prefab de la pelota en la posición y rotación del shootingPoint
        GameObject ball = Instantiate(ballPrefab, shootingPoint.position, shootingPoint.rotation);
        
        // Obtener el Rigidbody2D del objeto instanciado
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Aplicar una fuerza en la dirección del shootingPoint
            Vector2 direction = shootingPoint.up;  // Toma la dirección del 'up' del shootingPoint (basado en su rotación)
            rb.AddForce(direction * launchForce);
        }
    }
}
