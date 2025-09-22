using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    public void PlatformAnimationActivation()
    {
        anim.SetTrigger("AnimationActivation");
    }

    public void OnDoorActivation()
    {
        anim.SetTrigger("DoorActivation");
    }

    public void OnButtonActivation()
    {
        anim.SetTrigger("ButtonActivation");
    }
}
