using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool IsButtonActivated;
    public bool stop;
    public GameObject ActivatedObjects;

    private Animator anim;
    private GameObject platform;
    private GameObject button;

    void Start()
    {
        IsButtonActivated = false;
        stop = false;
        
    }

    void Update()
    {
        if (IsButtonActivated == true)
        {
            if (gameObject.name == "Button1")
            {
                ActivatedObjects.SetActive(true);
            }
            
            if (gameObject.name == "Button2")
            {
                anim = ActivatedObjects.GetComponent<Animator>();
                anim.SetTrigger("AnimationActivation");
            }

            if (gameObject.name == "Button3")
            {
                ActivatedObjects.SetActive(true);
            }

            if (gameObject.name == "Button4")
            {
                ActivatedObjects.SetActive(true);
            }

            if (gameObject.name == "Button5")
            {
                ActivatedObjects.SetActive(false);
            }

            if (gameObject.name == "Button6")
            {
                ActivatedObjects.SetActive(true);
            }

            if (gameObject.name == "Button7" && stop == false)
            {
                ActivatedObjects.SetActive(true);
                platform = GameObject.Find("StoneBridge");
                anim = platform.GetComponent<Animator>();
                anim.SetTrigger("AnimationActivation");
            }

            if (gameObject.name == "Button8")
            {
                stop = true;
                button = GameObject.Find("ButtonParent (3)");
                ActivatedObjects.SetActive(false);
                button.SetActive(false);
            }
        }
    }
}
