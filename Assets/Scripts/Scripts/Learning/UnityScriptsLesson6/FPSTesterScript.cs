using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSTesterScript : MonoBehaviour
{
    private float fuel = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < 3f)
        {
            fuel -= 0.01f;
        }
        else
        {
            Debug.Log("fuel:" + fuel);
        }
    }
}
