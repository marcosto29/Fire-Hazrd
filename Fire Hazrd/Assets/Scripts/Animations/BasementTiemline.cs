using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BasementTiemline : MonoBehaviour
{
    public PlayableDirector[] director;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (GlobalInventory.animationflags[1])
        {
            director[0].Play();
            GlobalInventory.animationflags[1] = false;
        }

        if (GlobalInventory.animationflags[3])
        {
            director[1].Play();
            GlobalInventory.animationflags[0] = true;
            GlobalInventory.animationflags[3] = false;
        }

    }
}
