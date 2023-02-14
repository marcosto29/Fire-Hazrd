using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class HallTimeline : MonoBehaviour
{
    //public TimelineAsset timeline;
    public PlayableDirector director;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
            director.Play();
        
    }
}
