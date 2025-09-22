using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggersController : MonoBehaviour
{
    AnimationController animCont;
    ButtonScript BS;
    ButtonUI BUI;
    public CameraBehaviourScript CBS;

    public GameObject Camera;


    private GameObject[] Enemy;
  
    public void Start()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");

    }

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

        if (triggerObject.CompareTag("BackToMenu"))
        {
            SceneManager.LoadScene(0);
        }

        if (triggerObject.CompareTag("ButtonActivationTrigger"))
        {
                animCont.OnButtonActivation();
                BS.IsButtonActivated = true;
        }

    }

    public void OnTriggerStay(Collider triggerObject)
    {
        BUI = triggerObject.GetComponent<ButtonUI>();

        if (triggerObject.CompareTag("DoorActivationTrigger"))
        {


            if (Input.GetKeyUp(KeyCode.E) || (Input.GetKeyUp(KeyCode.E) && Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.E) && Input.GetKeyUp(KeyCode.Space)))
                {
                    BUI.buttonPanel.SetActive(false);
                    animCont.OnDoorActivation();
                    BUI.IsItDone = true;

            }

        }

        if (triggerObject.CompareTag("NoticingTrigger"))
        {

            foreach (GameObject enemy in Enemy)
            {
                enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, transform.position, Time.deltaTime * 6);

            }
        }

    }


}
