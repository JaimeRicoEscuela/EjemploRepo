using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploEstructuras : MonoBehaviour
{
    // Declaración de un Array
    int[] numerosArray = { 1, 2, 3, 4, 5 };

    // Declaración de una Lista
    List<string> listaNombres = new List<string>() { "Juan", "Maria", "Carlos" };

    // Declaración de un Diccionario
    Dictionary<string, int> diccionarioEdades = new Dictionary<string, int>()
    {
        {"Juan", 25 },
        {"Maria", 30 },
        {"Carlos", 22 }
    };

    void Start()
    {
        // Acceso a valores en el Array usando un bucle for
        Debug.Log("Valores del Array usando for:");
        for (int i = 0; i < numerosArray.Length; i++)
        {
            Debug.Log("Número: " + numerosArray[i]);
        }

        // Acceso a valores en la Lista usando un bucle foreach
        Debug.Log("Valores de la Lista usando foreach:");
        foreach (string nombre in listaNombres)
        {
            Debug.Log("Nombre: " + nombre);
        }

        // Acceso a valores en el Diccionario usando un bucle while
        Debug.Log("Valores del Diccionario usando while:");
        List<string> claves = new List<string>(diccionarioEdades.Keys);  // Extraer las claves en una lista
        int indice = 0;

        while (indice < claves.Count)
        {
            string clave = claves[indice];
            int valor = diccionarioEdades[clave];
            Debug.Log("Nombre: " + clave + ", Edad: " + valor);
            indice++;
        }
    }
}
