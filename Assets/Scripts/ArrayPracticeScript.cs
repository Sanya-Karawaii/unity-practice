using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPracticeScript : MonoBehaviour
{
    [SerializeField] private int[] _numbers;

    private void Start()
    {
        float sum = 0;

        for (int i = 0; i < _numbers.Length; i++)
        {
            sum += _numbers[i];
        }

        float result = sum / _numbers.Length;

        Debug.Log($"Среднее арифметическое чисел в массиве: {result}");
    }
}

