using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanScript : MonoBehaviour
{
    public GameObject Superman;

    public GameObject BadGuys;
    public GameObject CloneBadGuys;

    public MenuScriptUP9 MN;


    public Rigidbody r;
    public float Power;
    public Vector3 hitdirection;
    public Vector3 direction;

    public Vector3 SupermanPosition = new Vector3(14.7f, 0.9690773f, 1.51f);

    void Start()
    {
        CloneBadGuys = Instantiate(BadGuys, Vector3.zero, Quaternion.Euler(0, 0, 0), MN.p1.transform);
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
