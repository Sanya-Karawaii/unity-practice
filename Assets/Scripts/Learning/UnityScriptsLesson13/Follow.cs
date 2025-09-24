using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.position;
    }
}
