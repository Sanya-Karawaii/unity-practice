using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BoxCaster : MonoBehaviour
{
    void Start()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.localScale, Quaternion.identity);

        foreach (Collider collider in colliders)
        {
            Debug.Log(collider.gameObject.name);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
