using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript_17 : MonoBehaviour
{
    private SliderJoint2D slider;
    private JointMotor2D motor;
    private Vector3 firstPosition;
    private Vector3 secondPosition;

    void Start()
    {
        slider = gameObject.GetComponent<SliderJoint2D>();
        motor = slider.motor;
        firstPosition = new Vector2(-6.895f, -5.15f);
        secondPosition = new Vector2(-9.455f, -5.15f);


    }


    void Update()
    {
        if (gameObject.transform.position == firstPosition)
        {
            motor.motorSpeed = -1.0f;
            slider.motor = motor;

        }
        else if (gameObject.transform.position == secondPosition)
        {
            motor.motorSpeed = 1.0f;
            slider.motor = motor;

        }



    }
}
