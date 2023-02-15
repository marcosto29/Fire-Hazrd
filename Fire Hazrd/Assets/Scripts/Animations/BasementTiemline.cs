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
        if (GlobalInventory.flags[1])
        {
            director[0].Play();
            GlobalInventory.flags[1] = false;
        }

        if (GlobalInventory.flags[3])
        {
            director[1].Play();
            GlobalInventory.end = true;
            GlobalInventory.flags[3] = false;
        }

    }
}
