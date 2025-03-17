using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FirstOfOccurenceScript : MonoBehaviour
{
    public void OnFirstOccurrence()
    {
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOfOccurence(array, value);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value}  в массив: {got} - {message}");

        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOfOccurence(array, value);
        message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
    }

    private int FirstOfOccurence(int[] array, int value)
    {

        for (int i = 0; i < array.Length; i++ )
        {
            if (value == array[i])
            {
                return i;
            }
        }

        return -1;
    }
}