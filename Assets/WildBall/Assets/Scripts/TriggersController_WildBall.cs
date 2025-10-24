using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggersController_WildBall : MonoBehaviour
{
    AnimationController1 animCont;
    ButtonScript BS;
    BonusScript BoS;
    ButtonUI BUI;
    Animator anim;
    [SerializeField] public PauseScript1 PS;
    public CameraBehaviourScript CBS;
    public Transform BallParent;


    public GameObject Camera;

    private Vector3 direction;
    private float speed = 5;
    private float maxSpeed = 6.0f;
    private GameObject[] Enemy;
    public bool Stop;

    public void Start()
    {
        Stop = false;
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");

    }

    private void OnTriggerEnter(Collider triggerObject)
    {
        animCont = triggerObject.GetComponent<AnimationController1>();
        anim = triggerObject.GetComponent<Animator>();
        BS = triggerObject.GetComponent<ButtonScript>();
        BoS = triggerObject.GetComponent<BonusScript>();


        if (triggerObject.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (triggerObject.CompareTag("FinishTrigger"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                Stop = true;
                PS.GameWin();
                
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
                

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

        if (triggerObject.CompareTag("Bonus"))
        {
                anim.SetTrigger("AnimationActivation");
                BoS.Play();
                Destroy(triggerObject.gameObject, 2);
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
