using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    [SerializeField] public Transform playerPosition;

    public Vector3 offset;
    public Quaternion[] cameraRotations = { Quaternion.Euler(24.205f, 122.589f, 0), Quaternion.Euler(29.257f, -264.189f, 0), Quaternion.Euler(30.288f, 123.83f, 0) };
    public Vector3[] cameraPositions = { new Vector3(17.82f, 33.26f, 130.91f), new Vector3(30.288f, 123.83f, 0), new Vector3(30.288f, 123.83f, 0) };

    private void Start()
    {
        offset = transform.position - playerPosition.position;
    }


    private void FixedUpdate()
    {
        transform.position = playerPosition.position + offset;
    }

}
