using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggersController : MonoBehaviour
{
    AnimationController animCont;
    ButtonScript BS;

    private void OnTriggerEnter(Collider triggerObject)
    {
        animCont = triggerObject.GetComponent<AnimationController>();
        BS = triggerObject.GetComponent<ButtonScript>();

        if (triggerObject.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (triggerObject.CompareTag("FinishTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (triggerObject.CompareTag("ButtonActivationTrigger"))
        {
                animCont.OnButtonActivation();
                BS.IsButtonActivated = true;
        }
    }

    public void OnTriggerStay(Collider triggerObject)
    {
        if (triggerObject.CompareTag("DoorActivationTrigger"))
        {
            if (Input.GetKeyUp(KeyCode.Tab) || (Input.GetKeyUp(KeyCode.Tab) && Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.Tab) && Input.GetKeyUp(KeyCode.Space)))
                {
                    animCont.OnDoorActivation();
                }

        }

    }
}
