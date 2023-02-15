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
        if (GlobalInventory.flags[2])
        {
            director.Play();
            GlobalInventory.flags[2] = false;
        }
            
               
    }
}
