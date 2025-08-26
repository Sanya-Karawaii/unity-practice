using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastScript : MonoBehaviour
{
    public float TimeToExplosion;
    public float Power;
    public float Radius;

    void Update()
    {
        TimeToExplosion -= Time.deltaTime;

        if (TimeToExplosion <= 0)
        {
            BlastActivation();
        }
    }

    void BlastActivation()
    {
        Rigidbody[] practiceObjects = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody po in practiceObjects)
        {
            if (Vector3.Distance(transform.position, po.transform.position) < Radius)
            {
                Vector3 direction = po.transform.position - transform.position;
                po.AddForce(direction.normalized * Power * (Radius - Vector3.Distance(transform.position, po.transform.position)), ForceMode.Impulse);
            }
        }

        TimeToExplosion = 3;
    }
}
