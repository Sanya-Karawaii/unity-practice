
using UnityEngine;

[RequireComponent(typeof(PlayerMovement13))]

public class PlayerInput13 : MonoBehaviour
{
    private Triggers13Script TS;
    private Vector3 movement;
    private PlayerMovement13 playerMovement;
    private float horizontal;
    private float vertical;
    private Vector3 lastPosition;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement13>();
        TS = GetComponent<Triggers13Script>();

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
