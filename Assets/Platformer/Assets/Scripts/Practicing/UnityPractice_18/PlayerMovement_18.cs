using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AnimationController_18))]

public class PlayerMovement_18 : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    [SerializeField] private bool isGrounded = false;
    [SerializeField] private bool isGettingHit = false;

   [Header("Settings")]
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffset;
    [SerializeField] private LayerMask groundMask;

    private AnimationController_18 animCon;
    private HealthScript_18 hs;

    private Rigidbody2D rb;
    [SerializeField] public SpriteRenderer sr;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        animCon = GetComponent<AnimationController_18>();
        hs = GetComponent<HealthScript_18>();
       
        

    }

    private void FixedUpdate()
    {
        Vector3 overlapCirclePosition = groundColliderTransform.position;
        isGrounded = Physics2D.OverlapCircle(overlapCirclePosition, jumpOffset, groundMask);
    }

    public void Move(float direction, bool isJumpButtonPressed)
    {
        if (hs.isAlive == true)
        {
            if (isJumpButtonPressed)
            {
                Jump();

            }

            if (Mathf.Abs(direction) > 0.01f)
            {
                HorizontalMovement(direction);

            }


            AnimationCheck(direction, isJumpButtonPressed);
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }

    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            
        }

    }

    public void Bounce()
    {
        isGettingHit = true;
        rb.velocity = new Vector2(-4 * Input.GetAxis(GlobalStringVars_18.hor), rb.velocity.y);
        
    }


    private void HorizontalMovement(float direction)
    {
        if (!isGettingHit)
        {
            
            rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
        }

    }

    private void AnimationCheck(float direction, bool isJumpButtonPressed)
    {
        if (direction == 0)
        {
            animCon.OnIdleTriggerActivation();
        }
        else
        {
            if (direction <= -0.01)
            {
                sr.flipX = true;
            }
            else if (direction >= 0.01)
            {
                sr.flipX = false;
            }

            animCon.OnRunningTriggerActivation();
        }

        animCon.OnJumpTriggerActivation(isGrounded);

    }

    private void TurnOffBounce()
    {
        isGettingHit = false;
    }


    
}
