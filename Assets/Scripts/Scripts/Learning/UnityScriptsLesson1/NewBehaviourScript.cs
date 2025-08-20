using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text inputFieldText;
    [SerializeField] private Button button;

    void Start()
    {
        
    }

    public void ReadMessage()
    {
        int a = Convert.ToInt32(inputFieldText.text);
        Debug.Log(a);
    }
}
