using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private Vector3 movement;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    Debug.Log("нажал");
            //}

            ////if (Inputs.GetKeyDown)
            ////           GetKeyUp
            ////           GetButtonDown
            ////           GetButtonUp
            ////           GetMouseButton
            ////           GetMouseButtonDown
            ////           GetMouseButtonUp

            //if (Input.GetMouseButtonDown(0))  /* 0 - левая кнопка мыши, 1 - правая кнопка мыши, 2 - колесико мыши*/
            //    Debug.Log("Fire");


            //if (Input.GetButtonDown(GlobalStringVars.JUMP_BUTTON))
            //{
            //    Debug.Log("Нажали прыжок");
            //}

            ////Debug.Log(Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS));
            ////Debug.Log(Input.GetAxis(GlobalStringVars.VERTICAL_AXIS));
            ///

            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            movement = new Vector3(-horizontal, 0, -vertical).normalized;   //приводим вектор к единичному значению
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }

    }
}
