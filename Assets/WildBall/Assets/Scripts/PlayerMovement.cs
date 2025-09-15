using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0, 15)] private float speed = 5.0f;
    [SerializeField] private float jumpPower = 5.0f;
    private Rigidbody playerRgbd;
    public Rigidbody ObjectParent;

    void Start()
    {
        ObjectParent = GetComponent<Rigidbody>();
        playerRgbd = GetComponent<Rigidbody>();
    }

    public void MovePlayer(Vector3 movement)
    {
        playerRgbd.AddForce(movement * speed);
    }

    public void JumpButton()
    {
        ObjectParent.AddForce(0, jumpPower, 0, ForceMode.Impulse);
    }

#if UNITY_EDITOR
        [ContextMenu("Reset Values")]
        public void ResetValues()
        {
            speed = 5;
        }
#endif

}
