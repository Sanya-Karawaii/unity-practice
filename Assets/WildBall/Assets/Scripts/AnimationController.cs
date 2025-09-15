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


    void Update()
    {

    }

    //private void OnAnimationEnding()
    //{
    //    value = Random.Range(1, 4);
    //    anim.SetTrigger("AnimationEnding");
    //    anim.SetInteger("AnimationID", value);
    //    Debug.Log(value);
    //}

    public void OnDoorActivation()
    {
        anim.SetTrigger("DoorActivation");
    }

    public void OnButtonActivation()
    {
        anim.SetTrigger("ButtonActivation");
    }
}
