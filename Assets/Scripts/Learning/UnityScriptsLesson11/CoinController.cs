using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Alive", false);
        anim.SetTrigger("Collect");
        Destroy(gameObject, 0.9f);
    }
    
}
