using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool start = true;
    public static bool[] animationflags = { false, false, false, false };
    public static bool[] flags = { false, false, false, false };
    public static string[] names = { "Key", "BasementPart", "RoomPart", "cat" };

    public static void Unlock(string name)
    {
        int i = System.Array.IndexOf(names,name);
        flags[i] = true;
        if(i!=0)
            animationflags[i] = true;
    }

}
