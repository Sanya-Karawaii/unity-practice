using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardTableScript : MonoBehaviour
{
    public GameObject BilliardBall;
    public Rigidbody Bb;
    public float Power;
    public Vector3 vec;

    public GameObject OtherBalls;
    public GameObject CloneOtherBalls;

    public bool kickTheBall;

    public MenuScriptUP9 MN;

    public Vector3 BilliardBallPosition = new Vector3(7.48f, 0.71f, 1.83f);

    void Start()
    {

        CloneOtherBalls = Instantiate(OtherBalls, new Vector3(0, -0.59f, -4.94f), Quaternion.Euler(0, 0, 0), MN.p2.transform);

        Bb = BilliardBall.GetComponent<Rigidbody>();
        vec = new Vector3(-5, 0,0);

        Bb.AddForce(vec * Power, ForceMode.Impulse);

    }

    
    void Update()
    {
        if (kickTheBall)
            Bb.AddForce(vec * Power, ForceMode.Impulse);
            kickTheBall = false;
    }
}
