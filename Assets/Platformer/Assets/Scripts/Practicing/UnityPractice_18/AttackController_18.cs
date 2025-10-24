using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController_18 : MonoBehaviour
{
    [SerializeField] private Collider2D attCollider;

    private AnimationController_18 animCont;
    private PlayerMovement_18 playerMov;


    public bool isAttacking = false;


    private void Awake()
    {
        animCont = GetComponent<AnimationController_18>();
        playerMov = GetComponent<PlayerMovement_18>();
    }

    public void Attack(float direction)
    {
        if (direction == 0)
        {
            if (playerMov.sr.flipX == true)
            {
                attCollider.gameObject.transform.localScale = new Vector2(transform.localScale.x * -0.25f, transform.localScale.y * -0.25f);
            }
            else
            {
                attCollider.gameObject.transform.localScale = new Vector2(transform.localScale.x * 0.25f, transform.localScale.y * 0.25f);
            }
        }

        if (direction > 0)
        {
            attCollider.gameObject.transform.localScale = new Vector2(transform.localScale.x * 0.25f, transform.localScale.y * 0.25f);

        }
        else if (direction < 0)
        {
            attCollider.gameObject.transform.localScale = new Vector2(transform.localScale.x * -0.25f, transform.localScale.y * -0.25f);
        }


        if (!isAttacking)
        {
            isAttacking = true;
            attCollider.gameObject.SetActive(true);
            animCont.OnAttackTriggerActivation();
        }

        
    }

    public void IsAttacking()
    {
        isAttacking = false;
        attCollider.gameObject.SetActive(false);
        animCont.StopAttackTriggerActivation();
    }


}
