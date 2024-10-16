using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        // Movimiento del jugador
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moverHorizontal, 0.0f, moverVertical);
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto con el que colisiona tiene la etiqueta "Recolectable"
        if (other.CompareTag("Recolectable"))
        {
            // Llamar al método para recolectar el objeto en el GameManager
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.RecolectarObjeto(other.gameObject);
        }
    }
}
