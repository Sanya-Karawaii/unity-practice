using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateObjectsScript : MonoBehaviour
{
    public MenuState10Script MS;

    public GameObject Bricks;
    public GameObject WreckingBall;

    public GameObject CBricks;
    public GameObject CWreckingBall;

    void Start()
    {
        CWreckingBall = Instantiate(WreckingBall, new Vector3(0, 3.147f, 1.439f), Quaternion.Euler(-90, 0, 0), MS.p1.transform);
        CBricks = Instantiate(Bricks, new Vector3(-0.375f, 1.081f, -1.808f), Quaternion.Euler(0, 0, 0), MS.p1.transform);
    }
    void Update()
    {
        
    }
}
