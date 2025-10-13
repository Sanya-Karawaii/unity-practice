using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer_Learning : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageable"))
        {
            collision.gameObject.GetComponent<Health_Learning>().TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}
