using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        GlobalInventory.flags[0] = false;
        GlobalInventory.flags[1] = false;
        GlobalInventory.flags[2] = false;
        GlobalInventory.flags[3] = false;
        GlobalInventory.end = false;
        GlobalInventory.start = true;
    }

    // Update is called once per frame
    
}
