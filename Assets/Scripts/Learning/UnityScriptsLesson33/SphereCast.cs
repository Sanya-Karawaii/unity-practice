using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SphereCast : MonoBehaviour
{
    private float radius = 5f;

    void Start()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);  

        foreach (Collider collider in colliders)
        {
            Debug.Log(collider.gameObject.name);
        }
    }

   private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
