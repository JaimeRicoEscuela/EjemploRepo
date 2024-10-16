using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para reiniciar la escena

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;      // Número máximo de vidas
    public int currentLives;     // Número actual de vidas
    private Vector3 startPosition; // Posición inicial del personaje

    void Start()
    {
        // Al comenzar el juego, el personaje tiene el máximo número de vidas
        currentLives = maxLives;

        // Guardamos la posición inicial del personaje
        startPosition = transform.position;
    }

    void Update()
    {
     
       
    }

    // Función para manejar el daño al personaje
    public void TakeDamage()
    {
        currentLives--;  // Restamos una vida

        // Si aún tiene vidas, lo devolvemos a la posición inicial
        if (currentLives > 0)
        {
            transform.position = startPosition;
        }
       else
        {
            RestartScene(); // Reiniciamos la escena si se quedó sin vidas
        }
    }

    // Método para reiniciar la escena actual
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reinicia la escena actual
    }

    // Método para detectar colisiones
    void OnCollisionEnter(Collision collision)
    {
        // Si el personaje toca un objeto con la etiqueta "enemy"
        if (collision.gameObject.CompareTag("enemy"))
        {
            TakeDamage();  // Llamamos a la función de daño
        }
    }
}
