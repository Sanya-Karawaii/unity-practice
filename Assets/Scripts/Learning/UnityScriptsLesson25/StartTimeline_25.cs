using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartTimeline_25 : MonoBehaviour
{
    private PlayableDirector timeline;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timeline.Play();
        }
    }
}
