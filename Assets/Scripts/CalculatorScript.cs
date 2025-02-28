using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private InputField firstNumberEnterInput;
    [SerializeField] private InputField secondNumberEnterInput;
    [SerializeField] private Text resultOutput;


    public void onAdditionOperationClick()
    {
        float firstNumber = float.Parse(firstNumberEnterInput.text);
        float secondNumber = float.Parse(secondNumberEnterInput.text);

        float result = firstNumber + secondNumber;
        resultOutput.text = Convert.ToString(result);

    }

    public void onSubstractionOperationClick()
    {
        float firstNumber = float.Parse(firstNumberEnterInput.text);
        float secondNumber = float.Parse(secondNumberEnterInput.text);

        float result = firstNumber - secondNumber;
        resultOutput.text = Convert.ToString(result);

    }

    public void onMultiplicationOperationClick()
    {
        float firstNumber = float.Parse(firstNumberEnterInput.text);
        float secondNumber = float.Parse(secondNumberEnterInput.text);

        float result = firstNumber * secondNumber;
        resultOutput.text = Convert.ToString(result);
    }

    public void onDivisionOperationClick()
    {
        float firstNumber = float.Parse(firstNumberEnterInput.text);
        float secondNumber = float.Parse(secondNumberEnterInput.text);

        float result = firstNumber / secondNumber;
        resultOutput.text = Convert.ToString(result);
    }
}
