using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]    //делает обязательным наличие компонента в Инспекторе объекта

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRgbd;
        

        private void Awake()
        {
            playerRgbd = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRgbd.AddForce(movement * speed);
        }

#if UNITY_EDITOR
        [ContextMenu("reset values")]
        public void ResetValues()
        {
            speed = 2;
        }
#endif
    }
}
