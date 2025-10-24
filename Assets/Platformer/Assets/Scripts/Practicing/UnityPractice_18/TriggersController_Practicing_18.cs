using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersController_Practicing_18 : MonoBehaviour
{
    private HealthScript_18 hs;
    private Collider2D collider;

    private void Awake()
    {
        hs = GetComponent<HealthScript_18>();
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
