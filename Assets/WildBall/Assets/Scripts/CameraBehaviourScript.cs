using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    [SerializeField] public Transform playerPosition;

    public Vector3 offset;
    private float smoothSpeed = 10.0f;

    private void Start()
    {
        offset = transform.position - playerPosition.position;
    }


    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, playerPosition.position + offset, Time.deltaTime * smoothSpeed);
    }

}
