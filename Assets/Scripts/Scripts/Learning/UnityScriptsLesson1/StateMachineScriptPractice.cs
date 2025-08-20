using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineScriptPractice : MonoBehaviour
{
    [SerializeField] private GameObject firstCanvas;
    [SerializeField] private GameObject secondCanvas;

    private GameObject currentCanvas;

    private void Start()
    {
        firstCanvas.SetActive(true);
        currentCanvas = firstCanvas;

    }

    public void ChangeState(GameObject state)
    {
        if (currentCanvas != null)
        {
            currentCanvas.SetActive(false);
            state.SetActive(true);
            currentCanvas = state;
        }
    }

}
