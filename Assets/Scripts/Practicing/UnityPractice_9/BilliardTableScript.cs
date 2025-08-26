using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardTableScript : MonoBehaviour
{
    public Rigidbody BilliardBall;

    void Start()
    {
        BilliardBall.GetComponent<Rigidbody>();
        BilliardBall.AddForce(-30, 0, 0, ForceMode.Impulse);
    }

    
    void Update()
    {
        
    }
}
