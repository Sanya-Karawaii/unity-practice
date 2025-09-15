using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - playerPosition.position;
    }

    private void FixedUpdate()
    {
        transform.position = playerPosition.position + offset;
    }
}
