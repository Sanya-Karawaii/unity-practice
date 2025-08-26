using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanScript : MonoBehaviour
{
    public GameObject Superman;
    public Rigidbody r;
    public float Power;
    private Vector3 hitdirection;
    public Vector3 direction;

    void Start()
    {
        r = Superman.GetComponent<Rigidbody>();
        hitdirection = new Vector3(10, 10, 0 );
    }


    void Update()
    {
        r.AddForce(-5, 0, 0, ForceMode.Acceleration);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody e = collision.gameObject.GetComponent<Rigidbody>();

        if (e.gameObject.layer == 8)
        {
            direction = e.transform.position - Superman.transform.position;
            e.AddForce(hitdirection.magnitude * direction.normalized * Power, ForceMode.Impulse);
        }

    }
}
