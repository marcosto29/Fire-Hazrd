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
        if (Global.flags[1])
        {
            director[0].Play();
        }

        if (Global.flags[3])
        {
            director[1].Play();
            Global.end = true;
        }

    }
}
