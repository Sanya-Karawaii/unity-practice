using UnityEngine;

public class DamageDealer_18 : MonoBehaviour
{
    [SerializeField] private float damage;
    private bool isHit = false;

    private AttackController_18 attCont;

    private void Awake()
    {
        if (gameObject.tag == "Player")
        {
            attCont = GetComponent<AttackController_18>();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!isHit)
        {
            isHit = true;

            if (col.CompareTag("Damageable") || col.CompareTag("Player"))
            {
                if (gameObject.tag != "Player")
                {
                    col.gameObject.GetComponent<HealthScript_18>().TakeDamage(damage, col);

                }
                else
                {
                    if (attCont.isAttacking == true)
                    {
                        col.gameObject.GetComponent<HealthScript_18>().TakeDamage(damage, col);
                    }
                }

            }
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        isHit = false;
    }

 
}
