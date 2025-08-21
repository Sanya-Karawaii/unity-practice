using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SumOfEvenNumbersInRangeScript : MonoBehaviour
{
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "��������� ������" : $"��������� ��������, ��������� {want}";
        Debug.Log($"����� ������ ����� � ��������� �� {min} �� {max} ������������: {got} - {message}");
    }

    private int SumEvenNumbersInRange(int min, int max)
    {
        int sum = 0;

        for (int i = min; i < max; i++)
        {
            if (i % 2 == 0)
            { 
                sum += i;
            }
        }

        //����������� �������:
        //int start = min % 2 == 0 ? min : min + 1;
        //for (int i = start; i <= max; i += 2)
        //{
        //    sum += i;
        //}

        return sum;
    }
}
