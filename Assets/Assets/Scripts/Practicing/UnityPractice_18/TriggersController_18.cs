using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersController_18 : MonoBehaviour
{
    private HealthScript hs;
    private Collider2D collider;

    private void Awake()
    {
        hs = GetComponent<HealthScript>();
        collider = GetComponent<BoxCollider2D>(); 
    }
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("DeathTrigger"))
        {
            hs.CollisionWithBoundaries(collider);

        }
    }
}
