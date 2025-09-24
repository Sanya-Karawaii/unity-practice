using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript13 : MonoBehaviour
{
    [SerializeField] public Transform playerPosition;

    public Triggers13Script TS;
    private Vector3 offset;
    private Vector3 lastPosition;

    private void Start()
    {
        offset = transform.position - playerPosition.position;
    }


    private void FixedUpdate()
    {
        if (TS.Stop == false)
        {
            transform.position = playerPosition.position + offset;
            lastPosition = transform.position;
        }
        else
        {
            transform.position = lastPosition;
        }
    }

}
