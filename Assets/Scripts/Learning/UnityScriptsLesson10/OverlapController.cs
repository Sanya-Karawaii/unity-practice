using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapController : MonoBehaviour
{
    public float rad;
    public LayerMask layerM;

    void Start()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, rad, layerM); /*- параметры: Vector3 - position, float - radius, int - layer mask*/

        foreach(Collider col in colls)
        {
            Destroy(col.gameObject);
            Debug.Log(col.name);
        }
    }


    void Update()
    {
        
    }
}
