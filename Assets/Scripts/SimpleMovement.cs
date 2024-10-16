using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;  // Velocidad de movimiento

    void Update()
    {
        // Mueve el objeto hacia la derecha (Vector2.right) multiplicado por la velocidad y por el deltaTime
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}

