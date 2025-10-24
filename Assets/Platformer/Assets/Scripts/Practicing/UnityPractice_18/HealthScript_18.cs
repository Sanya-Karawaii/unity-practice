using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AnimationController_18))]
public class HealthScript_18 : MonoBehaviour
{
    [SerializeField] private AnimationController_18 animCont;
    [SerializeField] private GameState_18 GS;
    [SerializeField] private PlayerMovement_18 playerMovement;
    private EnemyHealthBar_18 EHB;
    

    [SerializeField] public float maxHealth;
    private float currentHealth;

    public bool isAlive;
    

    void Awake()
    {
        
        playerMovement = GetComponent<PlayerMovement_18>();
        animCont = GetComponent<AnimationController_18>();
        currentHealth = maxHealth;
        isAlive = true;

    }


    public void TakeDamage(float damage, Collider2D col)
    {
        currentHealth -= damage;
        CheckIsAlive();

        if (gameObject.tag == "Player")
        {
            playerMovement.Bounce();
            if (currentHealth <= 0)
            {
                GS.CheckCurrentHealth(currentHealth);
            }
            GS.ChangeHealthIndicator(damage);
            GS.DisplayHealthStatus(maxHealth, currentHealth);
        }
        else /*if (gameObject.tag == "Damageable" && GetComponent<EnemyHealthBar>() != null)*/
        {
            EHB = col.gameObject.GetComponent<EnemyHealthBar_18>();
            EHB.ChangeHealthBar(damage);
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
        yield return new WaitForSeconds(2);

        if (gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
