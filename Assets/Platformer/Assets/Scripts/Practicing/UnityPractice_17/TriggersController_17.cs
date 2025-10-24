using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggersController_17 : MonoBehaviour
{
    [SerializeField] private GameObject CartStopper;
    private Rigidbody2D rg;

    void Start()
    {
    }

    public void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject == CartStopper)
        {
            rg = obj.gameObject.GetComponent<Rigidbody2D>();
            rg.constraints = RigidbodyConstraints2D.None;
            StartCoroutine(DestroyObject());

        }


    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("DeathTrigger"))
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(2);
        CartStopper.SetActive(false);
        
    }
}
