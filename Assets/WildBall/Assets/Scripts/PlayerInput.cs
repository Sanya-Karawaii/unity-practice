
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]

public class PlayerInput : MonoBehaviour
{
    private Vector3 movement;
    private PlayerMovement playerMovement;
    private float horizontal;
    private float vertical;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();

    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movement = new Vector3(-horizontal, 0, -vertical).normalized;

        ObjectBehaviour();

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
        playerMovement.MovePlayer(movement);

    }

}
