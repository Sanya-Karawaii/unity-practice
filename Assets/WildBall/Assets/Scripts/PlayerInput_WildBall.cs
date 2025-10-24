
using UnityEngine;

[RequireComponent(typeof(PlayerMovement_WildBall))]

public class PlayerInput_WildBall : MonoBehaviour
{
    private TriggersController_WildBall TS;
    private Vector3 movement;
    private PlayerMovement_WildBall playerMovement;
    private float horizontal;
    private float vertical;
    private Vector3 lastPosition;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement_WildBall>();
        TS = GetComponent<TriggersController_WildBall>();

    }

    void Update()
    {
        if (TS.Stop == false)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            movement = new Vector3(-horizontal, 0, -vertical).normalized;

            ObjectBehaviour();
        }

    }

    private void ObjectBehaviour()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerMovement.JumpButton();
        }
    }

    private void FixedUpdate()
    {
        if (TS.Stop == false)
        {
            lastPosition = transform.position;
            playerMovement.MovePlayer(movement);
        }
        else
        {
            transform.position = lastPosition;
        }
    }

}
