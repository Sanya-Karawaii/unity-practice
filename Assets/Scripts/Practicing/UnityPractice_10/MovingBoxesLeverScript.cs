using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoxesLeverScript : MonoBehaviour
{
    public GameObject MovingBoxesLever;

    private Vector3 firstPosition = new Vector3(1.17f, -4.49f, -6.37f);
    private Vector3 secondPosition = new Vector3(1.17f, -4.49f, -7.66f);

    private Vector3 target;

    //firstPosition = new Vector3(1.17f, -4.49f, -6.33f);
    //secondPosition = new Vector3(1.17f, -4.49f, -8.66f);

    void Start()
    {
        target = secondPosition;

    }


    void Update()
    {
        MovingBoxesLever.transform.localPosition = Vector3.MoveTowards(MovingBoxesLever.transform.localPosition, target, Time.deltaTime);

        if (MovingBoxesLever.transform.localPosition == secondPosition)
        {
            target = firstPosition;
        }
        else if (MovingBoxesLever.transform.localPosition == firstPosition)
        {
            target = secondPosition;
        }

    }

}
