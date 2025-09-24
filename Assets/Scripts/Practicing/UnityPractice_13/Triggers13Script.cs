using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers13Script : MonoBehaviour
{
    public BonusScript BS;
    public ParticleSystem PlayerPartSys;
    public Animator anim;

    public bool Stop;

    public void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Bonus"))
        {
            anim.SetTrigger("AnimationActivation");
            BS.Play();
            Destroy(obj.gameObject, 2);
        }

        if (obj.CompareTag("DeathTrigger"))
        {
            transform.position = transform.position;
            PlayerPartSys.Play();
            Stop = true;
            Destroy(gameObject, 1);

        } 
    }

}
