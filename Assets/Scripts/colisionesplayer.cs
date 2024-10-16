using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionesplayer : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        // Imprimir el nombre del objeto que entró en el trigger
        Debug.Log("Objeto entró en el trigger: " + other.gameObject.name);

        // Ejemplo: activar algún evento cuando el jugador entra en una zona específica
        if (other.CompareTag("Item"))
        {
            // Activar un evento, abrir una puerta, etc.
            Debug.Log("¡El jugador ha tocado el item!");
            Destroy(other.gameObject);
        }
    }
}
