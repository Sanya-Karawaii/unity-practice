using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AnimationController))]
public class HealthScript : MonoBehaviour
{
    [SerializeField] private AnimationController animCont;
    [SerializeField] private GameState GS;
    [SerializeField] public float maxHealth;
    private float currentHealth;

    public bool isAlive;
    

    void Start()
    {
        animCont = GetComponent<AnimationController>();
        currentHealth = maxHealth;
        isAlive = true;

    }


    public void TakeDamage(float damage, Collider2D col)
    {
        currentHealth -= damage;
        CheckIsAlive();

        if (gameObject.tag == "Player")
        {
            if (currentHealth <= 0)
            {
                GS.CheckCurrentHealth(currentHealth);
            } 
            GS.DisplayHealthStatus(maxHealth, currentHealth);
        }

    }

    private void CheckIsAlive()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isAlive = false;
            StartCoroutine(DestroyObject());
        }
        else
        {
            isAlive = true;
        }

        AnimationCheck();
    }

    private void AnimationCheck()
    {
        if (isAlive)
        {
            animCont.OnGettingHitTriggerActivation();
        }
        else
        {
            animCont.OnDeadTriggerAnimation();
        }
    }

    public void CollisionWithBoundaries(Collider2D collider)
    {
        float damage = maxHealth;
        TakeDamage(damage, collider);
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);

        if (gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
