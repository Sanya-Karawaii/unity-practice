using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravityBoxScript : MonoBehaviour
{

    public void OnTriggerEnter(Collider ball)
    {
        ball.gameObject.GetComponent<Rigidbody>().useGravity = false;
        ball.gameObject.GetComponent<Rigidbody>().drag = 1.2f;
    }

    public void OnTriggerExit(Collider ball)
    {
        ball.gameObject.GetComponent<Rigidbody>().useGravity = true;
        ball.gameObject.GetComponent<Rigidbody>().drag = 0;
    }
}
