using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class HallTimeline : MonoBehaviour
{
    //public TimelineAsset timeline;
    public PlayableDirector[] director;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Global.start)
        {
            director[0].Play();
            Global.start = false;
        }
            
        if(Global.end)
            director[1].Play();
    }
}
