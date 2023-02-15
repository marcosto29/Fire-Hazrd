using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        GlobalInventory.animationflags[0] = false;
        GlobalInventory.animationflags[1] = false;
        GlobalInventory.animationflags[2] = false;
        GlobalInventory.animationflags[3] = false;
        GlobalInventory.flags[0] = false;
        GlobalInventory.flags[1] = false;
        GlobalInventory.flags[2] = false;
        GlobalInventory.flags[3] = false;
        GlobalInventory.start = true;
    }


    
}
