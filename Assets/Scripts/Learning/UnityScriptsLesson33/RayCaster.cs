using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private float maxDistance = 5f;
    [SerializeField] private LayerMask layerMask;

    void Start()
    {
        Ray ray = new Ray(transform.position, Vector3.forward); 
        if (Physics.Raycast(ray, maxDistance, layerMask))
        {
            Debug.Log("hit!");
        }
    }
}
