using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class TwoNumbersComparerScript : MonoBehaviour
{
    [SerializeField] private InputField firstNumberEnterInput;
    [SerializeField] private InputField secondNumberEnterInput;
    [SerializeField] private Text resultOutput;

    public void onClickCheck()
    {
        float firstNumber = float.Parse(firstNumberEnterInput.text);
        float secondNumber = float.Parse(secondNumberEnterInput.text);

        if (firstNumber < secondNumber)
        {
            resultOutput.text = secondNumberEnterInput.text;
        }
        else if(firstNumber > secondNumber)
        {
            resultOutput.text = firstNumberEnterInput.text;
        }
        else if (firstNumber == secondNumber)
        {
            resultOutput.text = "Равны!";
        }
    }

    public void onClickClear()
    {
        resultOutput.text = null;
    }
       


}
