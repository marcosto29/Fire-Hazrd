using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        GlobalInventory.animationflags[0] = false;
        GlobalInventory.animationflags[1] = false;
        GlobalInventory.animationflags[2] = false;
        GlobalInventory.animationflags[3] = false;
        GlobalInventory.start = true;
    }

    // Update is called once per frame
    
}
