using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    private ButtonScript BS;
    public bool IsButtonActivated;
    public bool stop;
    [SerializeField] public GameObject ActivatedObjects;

    private Animator anim;
    private GameObject platform;
    private GameObject button;

    public UnityEvent OnActivated;

    void Start()
    {
        BS = GetComponent<ButtonScript>();
        IsButtonActivated = false;
        stop = false;

    }

    void Update()
    {
        if (IsButtonActivated == true)
        {
            OnActivated.Invoke();
            IsButtonActivated = false;
        }

        if (ActivatedObjects == null)
        {
            return;
        }
    }


}
