using UnityEngine;

[RequireComponent(typeof(PlayerMovement_18))]
[RequireComponent(typeof(AttackController_18))]

public class PlayerInput_18 : MonoBehaviour
{
    private PlayerMovement_18 playerMov;
    private AttackController_18 attackCon;

    private float horizontalDirection;
    private bool isAttackButtonPressed;
    private bool isJumpButtonPressed;

    private void Awake()
    {
        playerMov = GetComponent<PlayerMovement_18>();
        attackCon = GetComponent<AttackController_18>();

    }

    private void Update()
    {
        horizontalDirection = Input.GetAxis(GlobalStringVars.hor);
        isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.jump);
        isAttackButtonPressed = Input.GetButtonDown(GlobalStringVars.attack1);

        if (isAttackButtonPressed)
        {
            attackCon.Attack(horizontalDirection);
        }


        playerMov.Move(horizontalDirection, isJumpButtonPressed);
    }
}
