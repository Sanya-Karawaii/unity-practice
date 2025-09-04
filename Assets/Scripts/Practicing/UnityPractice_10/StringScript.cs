using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringScript : MonoBehaviour
{
    public GameObject StringLever;

    private Vector3 firstPosition;
    private Vector3 secondPosition;

    public float Timer;

    public bool ReturnToPosition;
    
    void Start()
    {
        firstPosition = new Vector3(1.17f, -9.12f, 4.02f);
        secondPosition = new Vector3(1.17f, -4.8f, 4.02f);


    }


    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            StringLever.transform.localPosition = secondPosition;
            ReturnToPosition = true;
            Timer = 5;
        }

        if (ReturnToPosition)
        {
            StringLever.transform.localPosition = Vector3.MoveTowards(StringLever.transform.localPosition, firstPosition, Time.deltaTime);
        }

        if (StringLever.transform.localPosition == firstPosition && ReturnToPosition)
        {
            ReturnToPosition = false;
        }
    }
}
