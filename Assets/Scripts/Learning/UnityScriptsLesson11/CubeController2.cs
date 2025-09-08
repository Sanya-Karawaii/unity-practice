using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController2 : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        anim.SetFloat("Velocity", rb.velocity.magnitude);
    }
}
