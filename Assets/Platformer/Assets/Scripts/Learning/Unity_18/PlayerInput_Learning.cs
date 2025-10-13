using UnityEngine;

[RequireComponent(typeof(PlayerMovement_Learning))]
[RequireComponent(typeof(Shooter_Learning))]

public class PlayerInput_Learning : MonoBehaviour
{
    private PlayerMovement_Learning playerMovement;
    private Shooter_Learning shooter;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement_Learning>();
        shooter = GetComponent<Shooter_Learning>();

    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis(GlobalStringVars_Learning.HORIZONTAL_AXIS);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars_Learning.JUMP);

        if (Input.GetButtonDown(GlobalStringVars_Learning.FIRE_1))
        {
            shooter.Shoot(horizontalDirection);
        }
        playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    }
}
