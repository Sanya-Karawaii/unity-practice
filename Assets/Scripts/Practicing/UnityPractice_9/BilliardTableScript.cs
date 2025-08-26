using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardTableScript : MonoBehaviour
{
    public GameObject BilliardBall;
    public Rigidbody Bb;
    public float Power;
    private Vector3 vec;


    void Start()
    {
        Bb = BilliardBall.GetComponent<Rigidbody>();
        vec = new Vector3(-5, 0,0);

        Bb.AddForce(vec * Power, ForceMode.Impulse);
    }

    
    void Update()
    {
        
    }
}
