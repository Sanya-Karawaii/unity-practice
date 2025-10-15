using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(AttackController))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMov;
    private AttackController attackCon;

    private float horizontalDirection;
    private bool isAttackButtonPressed;
    private bool isJumpButtonPressed;

    private void Awake()
    {
        playerMov = GetComponent<PlayerMovement>();
        attackCon = GetComponent<AttackController>();

    }

    private void Update()
    {
        horizontalDirection = Input.GetAxis(GlobalStringVars.hor);
        isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.jump);
        isAttackButtonPressed = Input.GetButtonDown(GlobalStringVars.attack1);

        if (isAttackButtonPressed)
        {
            attackCon.Attack1(horizontalDirection);
        }


        playerMov.Move(horizontalDirection, isJumpButtonPressed);
    }
}
