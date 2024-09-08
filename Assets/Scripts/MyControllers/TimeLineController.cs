using System;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController  : MonoBehaviour
{
    // Referencia al director o cinematica que queremos castear
    [SerializeField] private PlayableDirector _playableDirector;

    public void PlayTimeline()
    {
        // Starts a Timeline when the function is called
        _playableDirector.Play();
    }
}
