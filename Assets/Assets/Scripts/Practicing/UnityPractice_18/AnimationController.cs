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
        
    }

    public void OnJumpTriggerActivation(bool isJumping)
    {
        if (!isJumping)
        {
            OnIdleTriggerActivation();
            anim.SetBool("IsJumping", true);
        }
        else
        {
            anim.SetBool("IsJumping", false);
        }

    }

    public void OnGettingHitTriggerActivation()
    {
        anim.SetBool("IsGettingHit", true);
    }

    public void StopGettingHitTriggerActivation()
    {
        anim.SetBool("IsGettingHit", false);
    }

    public void OnDeadTriggerAnimation()
    {
        anim.SetBool("IsDead", true);
    }

}
