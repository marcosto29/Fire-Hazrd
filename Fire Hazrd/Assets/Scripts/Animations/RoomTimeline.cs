using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RoomTimeline : MonoBehaviour
{
    public PlayableDirector director;

    // Update is called once per frame
    void Update()
    {
        if (GlobalInventory.animationflags[2])
        {
            director.Play();
            GlobalInventory.animationflags[2] = false;
        }
            
               
    }
}
