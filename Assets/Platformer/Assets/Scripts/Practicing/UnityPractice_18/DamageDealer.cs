using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Damageable") || col.CompareTag("Player"))
        {
            col.gameObject.GetComponent<HealthScript>().TakeDamage(damage, col);
        }


    }

 
}
