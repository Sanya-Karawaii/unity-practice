using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool IsButtonActivated;
    public GameObject ActivatedObjects;

    void Start()
    {
        IsButtonActivated = false;
    }

    void Update()
    {
        if (IsButtonActivated == true)
        {
            if (gameObject.name == "Button1")
            {
                ActivatedObjects.SetActive(false);
            }
            
            if (gameObject.name == "Button2")
            {
                ActivatedObjects.SetActive(false);
            }

            if (gameObject.name == "Button3")
            {
                ActivatedObjects.SetActive(true);
            }
        }
    }
}
