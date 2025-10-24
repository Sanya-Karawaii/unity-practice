using UnityEngine;

[RequireComponent(typeof(PlayerMovement_Learning_18))]
[RequireComponent(typeof(Shooter_Learning_18))]

public class PlayerInput_Learning_18 : MonoBehaviour
{
    private PlayerMovement_Learning_18 playerMovement;
    private Shooter_Learning_18 shooter;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement_Learning_18>();
        shooter = GetComponent<Shooter_Learning_18>();

    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis(GlobalStringVars_18.hor);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars_18.jump);

        if (Input.GetButtonDown(GlobalStringVars_18.attack1))
        {
            shooter.Shoot(horizontalDirection);
        }
        playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    }
}
