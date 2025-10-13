using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(AttackController))]

public class PlayerInput : MonoBehaviour
{
    public PlayerMovement playerMov;
    public AttackController attackCon;

    public float horizontalDirection;
    public bool isAttackButtonPressed;
    public bool isJumpButtonPressed;



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
