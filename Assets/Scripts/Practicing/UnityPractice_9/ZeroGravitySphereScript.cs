using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravitySphereScript : MonoBehaviour
{
    public GameObject ZeroGravitySphere;

    public void OnTriggerEnter(Collider practiceObjects)
    {
        practiceObjects.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    public void OnTriggerExit(Collider practiceObjects)
    {
        practiceObjects.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
