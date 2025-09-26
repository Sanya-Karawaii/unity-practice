using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggersController : MonoBehaviour
{
    AnimationController1 animCont;
    ButtonScript BS;
    ButtonUI BUI;
    public CameraBehaviourScript CBS;
    public Transform BallParent;

    public GameObject Camera;

    private Vector3 direction;
    private float speed = 5;
    private float maxSpeed = 6.0f;
    private GameObject[] Enemy;
  
    public void Start()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");

    }

    private void OnTriggerEnter(Collider triggerObject)
    {
        animCont = triggerObject.GetComponent<AnimationController1>();
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
                direction = transform.position - enemy.transform.position;
                enemy.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(direction * speed, maxSpeed);

            }
        }

    }


}
