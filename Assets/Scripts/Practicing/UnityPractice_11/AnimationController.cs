using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    private int value = 0;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    void Update()
    {

    }

    private void OnAnimationEnding()
    {
        value = Random.Range(1, 4);
        anim.SetTrigger("AnimationEnding");
        anim.SetInteger("AnimationID", value);
    }

}
