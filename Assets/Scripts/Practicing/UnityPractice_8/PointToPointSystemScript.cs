using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToPointSystemScript : MonoBehaviour
{
    public Transform MainObject;

    public float Speed;
    public bool forward;

    public int i = 0;
    float distance;

    public Vector3 target;
    public Vector3[] positions = { new Vector3(-3.12f, 1.89f, -2.2f), new Vector3(0.14f, 3.67f, -2.2f), new Vector3(3.33f, 2.08f, -2.2f), new Vector3(2.54f, -1.43f, -2.2f), new Vector3(-2.22f, -1.43f, -2.2f) };

    void Start()
    {
        target = positions[i];

    }


    void Update()
    {
        MainObject.transform.position = Vector3.MoveTowards(MainObject.transform.position, target, Time.deltaTime * Speed);
        transform.LookAt(target);
        distance = Vector3.Distance(MainObject.position, target);

        if (i >= positions.Length - 1)
        {
            forward = false;
        }
        else if (i == 0)
        {
            forward = true;
        }

        if (forward == true && distance == 0)
        {
            if (i < positions.Length - 1)
            {
                i++;
                target = positions[i];
            }
        }
        else if (forward == false && distance == 0)
        {
            i--;
            target = positions[i];
        }

    }

}
