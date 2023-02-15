using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool start = true;
    public static bool end = false;
    public static bool[] flags = { false, false, false, false };
    public static string[] names = { "Key", "BasementPart", "RoomPart", "Cat" };

    public static void Unlock(string name)
    {
        int i = System.Array.IndexOf(names,name);
        flags[i] = true;
    }

}
