using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightScript : MonoBehaviour
{
    public float Timer;
    private Animator anim;
    private bool IsItRedSide;


    public GameObject woodenCart;

    void Start()
    {
        Timer = 5.0f;
        anim = gameObject.GetComponent<Animator>();
        IsItRedSide = true;
        anim.SetTrigger("Begin");
    }

    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            if (IsItRedSide)
            {
                anim.SetTrigger("AnimationActivation");
                IsItRedSide = false;
                woodenCart.SetActive(true);
                Timer = 5.0f;
            }
            else if (!IsItRedSide)
            {
                anim.SetTrigger("AnimationDeactivation");
                IsItRedSide = true;
                woodenCart.SetActive(false);
                Timer = 5.0f;
            }

        }
    }

}
