using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePinballScript : MonoBehaviour
{
    public GameObject ActivePinball;
    public GameObject Balls;
    public GameObject CActivePinball;
    public GameObject CBalls;

    public MenuState10Script MS;

    void Start()
    {
        CActivePinball = Instantiate(ActivePinball, new Vector3(-11.92f, 0.94f, 17.91f), Quaternion.Euler(0, 90, 0), MS.p2.transform);
        CBalls = Instantiate(Balls, new Vector3(-11.86f, 0.84f, 17.9f), Quaternion.Euler(0, 90, 0), MS.p2.transform);
    }
}
