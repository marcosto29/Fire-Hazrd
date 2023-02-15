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
        if (GlobalInventory.start)
        {
            director[0].Play();
            GlobalInventory.start = false;
        }
            
        if(GlobalInventory.animationflags[0])
            director[1].Play();
    }
}
