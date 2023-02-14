using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static bool[] flags = { false, false, false, false };
    public string[] names = { "Key", "BasementPart", "RoomPart", "Cat" };

    public static void Unlock(string name)
    {
        int i = name.IndexOf(name);
        flags[i] = true;
    }
}
