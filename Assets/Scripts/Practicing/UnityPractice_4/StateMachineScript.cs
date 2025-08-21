using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineScript : MonoBehaviour
{
    [SerializeField] private GameObject CalculatorScreen;
    [SerializeField] private GameObject TwoNumbersComparerScreen;

    private GameObject currentScreen;

    private void Start()
    {
        CalculatorScreen.SetActive(true);
        currentScreen = CalculatorScreen;
        
    }

    public void ChangeState(GameObject state)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
        
    }


}
