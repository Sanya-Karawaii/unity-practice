using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsPracticeScript : MonoBehaviour
{

    private void Start()
    {
        int n = 13;

        if (n > 0)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Debug.Log($"Число {n} не является простым");
                }
                else
                {
                    Debug.Log($"Число {n} является простым");
                }
            }
        }
    }
        
}


