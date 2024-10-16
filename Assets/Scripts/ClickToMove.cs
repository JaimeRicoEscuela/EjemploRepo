using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent agent; // Referencia al NavMesh Agent

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // Obtiene el componente NavMesh Agent
    }

    void Update()
    {
        // Detectar clic izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Lanza un rayo desde la cámara hasta el punto donde se hizo clic
            RaycastHit hit;

            // Si el rayo golpea un objeto en el terreno
            if (Physics.Raycast(ray, out hit))
            {
                // Verificar que el objeto sea parte del NavMesh (terreno o superficies navegables)
                if (hit.collider.gameObject.CompareTag("suelo")) // Asegúrate de etiquetar el terreno como "Ground"
                {
                    agent.SetDestination(hit.point); // Establece el destino del NavMesh Agent
                }
            }
        }
    }
}
