using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;

    private Vector3 offset;
    public Quaternion[] cameraPositions = { Quaternion.Euler(30.288f, 123.83f, 0), Quaternion.Euler(30.288f, 123.83f, 0), Quaternion.Euler(30.288f, 123.83f, 0) };

    private void Start()
    {
        offset = transform.position - playerPosition.position;
    }


    private void FixedUpdate()
    {
        transform.position = playerPosition.position + offset;
    }

    private void OnTriggerEnter(Collider triggerObject)
    {
        Debug.Log(2);
        //if (triggerObject.gameObject.name == "TriggerObject1")
        //{
        //    Debug.Log(2);
        //    transform.rotation = cameraPositions[0];
        //}
    }
}
