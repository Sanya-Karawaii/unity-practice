
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]

public class PlayerInput : MonoBehaviour
{
    private TriggersController TS;
    private Vector3 movement;
    private PlayerMovement playerMovement;
    private float horizontal;
    private float vertical;
    private Vector3 lastPosition;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        TS = GetComponent<TriggersController>();

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
