using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AnimationController))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    [SerializeField] private bool isGrounded = false;

    [Header("Settings")]
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffset;
    [SerializeField] private LayerMask groundMask;

    private AnimationController animCon;
    private HealthScript hs;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        animCon = GetComponent<AnimationController>();
        hs = GetComponent<HealthScript>();
       
        

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

    private void Fall()
    {
        
    }


    private void HorizontalMovement(float direction)
    {
        rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
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


    
}
