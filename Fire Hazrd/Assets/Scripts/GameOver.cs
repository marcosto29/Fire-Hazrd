using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        Global.flags[0] = false;
        Global.flags[1] = false;
        Global.flags[2] = false;
        Global.flags[3] = false;
        Global.end = false;
        Global.start = true;
    }

    // Update is called once per frame
    
}
