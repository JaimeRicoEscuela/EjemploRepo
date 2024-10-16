using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explicacion : MonoBehaviour
{
    int edad = 18;
    void Start()
    {
        if (edad >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }
        else if (edad >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres un niño");
        }
    }
}
