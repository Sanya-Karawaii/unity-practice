
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAll : MonoBehaviour
{
    [SerializeField] private float maxDistance = 10f;

    void Start()
    {
        RaycastHit[] hits;

        hits = Physics.RaycastAll(transform.position, Vector3.forward, maxDistance);

        Debug.DrawRay(transform.position, Vector3.forward * maxDistance, Color.red, 100000);

        foreach (RaycastHit hit in hits)
        {
            Debug.Log(hit.transform.position);

        }
    }

    
}
