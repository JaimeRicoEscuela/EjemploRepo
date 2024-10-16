using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectoresunidad : MonoBehaviour
{

    Rigidbody rb; 
    float fuerzaMagnitud=2f;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) {
        Vector3 fuerza = transform.forward * fuerzaMagnitud;
        rb.AddForce(fuerza, ForceMode.Impulse);
        }
    }
}
