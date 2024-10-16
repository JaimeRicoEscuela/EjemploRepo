using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variable privada estática para el puntaje
    private static int score;

    // Lista de objetos recolectables
    public List<GameObject> objetosRecolectables;

    // Propiedad para acceder al score
    public static int Score
    {
        get { return score; }
        private set { score = value; }
    }

    // Método para actualizar el puntaje cuando un objeto es recolectado
    public void RecolectarObjeto(GameObject objeto)
    {
        // Incrementar el puntaje
        Score += 10;
        // Mostrar el puntaje en la consola
        Debug.Log("Puntaje: " + Score);

        // Desactivar el objeto recolectado
        objeto.SetActive(false);

        // Remover el objeto de la lista de recolectables
        objetosRecolectables.Remove(objeto);
    }

    void Start()
    {
        // Iniciar el score en 0
        Score = 0;

        // Agregar todos los objetos con la etiqueta "Recolectable" a la lista
        objetosRecolectables = new List<GameObject>(GameObject.FindGameObjectsWithTag("Recolectable"));

        Debug.Log("Objetos recolectables: " + objetosRecolectables.Count);
    }
}
