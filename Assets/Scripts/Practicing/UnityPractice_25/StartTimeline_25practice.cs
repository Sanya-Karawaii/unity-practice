using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartTimeline_25practice : MonoBehaviour
{
    private PlayableDirector timeline;

    private bool IsTriggerCrossed = false;
    
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        
    }

    void Update()
    {
        if (IsTriggerCrossed)
        {
            timeline.Play();
            IsTriggerCrossed = false;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Aidared")
        IsTriggerCrossed = true;
    }

}
