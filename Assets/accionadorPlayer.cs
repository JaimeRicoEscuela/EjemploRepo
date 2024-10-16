using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accionadorPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("accionador"))
        {
           collider.gameObject.GetComponent<accionador>().Activate();
        }
    }
}
