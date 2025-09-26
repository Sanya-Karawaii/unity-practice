using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement13 : MonoBehaviour
{
    [SerializeField, Range(0, 15)] private float speed = 5.0f;
    [SerializeField] private float jumpPower = 5.0f;
    private Rigidbody playerRgbd;
    public Rigidbody ObjectParent;
    public bool PlayerJumped;
    private float Timer;

    void Start()
    {
        Timer = 3.0f;
        ObjectParent = GetComponent<Rigidbody>();
        playerRgbd = GetComponent<Rigidbody>();
    }

    public void MovePlayer(Vector3 movement)
    {
        playerRgbd.AddForce(movement * speed);
    }

    public void JumpButton()
    {
        if (PlayerJumped == false)
        {
            PlayerJumped = true;
            ObjectParent.AddForce(0, jumpPower, 0, ForceMode.Impulse);
            StartCoroutine(JumpCooldown());
        }

    }

    private IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(1.0f);
        PlayerJumped = false;
    }

#if UNITY_EDITOR
        [ContextMenu("Reset Values")]
        public void ResetValues()
        {
            speed = 5;
        }
#endif

}
