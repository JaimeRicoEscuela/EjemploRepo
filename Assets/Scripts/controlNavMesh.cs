using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controlNavMesh : MonoBehaviour
{
    public Transform objetivo;
    private  NavMeshAgent agent ;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        
    }

    
    void Update()
    {
        agent.SetDestination(objetivo.position);
    }
}
