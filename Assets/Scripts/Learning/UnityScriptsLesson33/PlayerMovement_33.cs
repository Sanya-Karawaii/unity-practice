using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement_33 : MonoBehaviour
{
    [SerializeField] private GameObject pointToMove;

    private NavMeshAgent navMeshAgent;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        RaycastHit hit;
        
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                pointToMove.transform.position = hit.point;

                navMeshAgent.destination = hit.point;
            }
        }
        
    }
}
