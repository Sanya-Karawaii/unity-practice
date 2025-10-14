using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void OnRunningTriggerActivation()
    {
        anim.SetBool("IsRunning", true);
    }

    public void OnIdleTriggerActivation()
    {
        anim.SetBool("IsRunning", false);
        anim.SetBool("IsJumping", false);
    }

    public void OnJumpTriggerActivation()
    {
        anim.SetBool("IsJumping", true);
    }
}
