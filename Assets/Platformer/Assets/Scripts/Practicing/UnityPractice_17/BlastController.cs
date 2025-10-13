using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastController : MonoBehaviour
{
    public GameObject barrel;
    public GameObject blast;
    public GameObject blastClone;
    public GameObject parent;
    public GameObject Cart;
    private PointEffector2D eff;
    private TargetJoint2D targ;
    private Rigidbody2D rb;

    void Start()
    {
        targ = GetComponent<TargetJoint2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject ==  barrel)
        {
            blastClone = Instantiate(blast, parent.transform);
            barrel.SetActive(false);
            rb.constraints = RigidbodyConstraints2D.None;
            targ.enabled = false;
            StartCoroutine(DestroyCart());
            eff = blastClone.GetComponent<PointEffector2D>();
            StartCoroutine(TurnOffEffector());
            StartCoroutine(DestroyObject());

        }
    }

    private IEnumerator TurnOffEffector()
    {
        yield return new WaitForSeconds(3);
        eff.enabled = false;
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);

    }

    private IEnumerator DestroyCart()
    {
        yield return new WaitForSeconds(5);
        Cart.SetActive(false);

    }
}
