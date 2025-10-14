using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] private GameState GS;
    [SerializeField] private float maxHealth;
    private float currentHealth;
    private bool isAlive;
    

    void Start()
    {
        currentHealth = maxHealth;
        isAlive = true;

    }


    public void TakeDamage(float damage, Collider2D col)
    {
        currentHealth -= damage;
        CheckIsAlive();

        if (col.CompareTag("Player"))
        {
            GS.CheckCurrentHealth(currentHealth);
            GS.DisplayHealthStatus(maxHealth, currentHealth);
        }

    }

    private void CheckIsAlive()
    {
        if (currentHealth <= 0)
        {
            isAlive = false;
            Destroy(gameObject);
        }
        else
        {
            isAlive = true;
        }
    }
}
