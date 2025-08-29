using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravitySphereScript : MonoBehaviour
{
    public GameObject ZeroGravitySphere;

    public GameObject PracticeObjects;
    public GameObject ClonePracticeObjects;

    public MenuScriptUP9 MN;

    public void Start()
    {
        ClonePracticeObjects = Instantiate(PracticeObjects, Vector3.zero, Quaternion.Euler(0, 0, 0), MN.p3.transform);
    }

    public void OnTriggerEnter(Collider practiceObjects)
    {
        practiceObjects.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    public void OnTriggerExit(Collider practiceObjects)
    {
        practiceObjects.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
