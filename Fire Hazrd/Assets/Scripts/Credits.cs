using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public string[] webs;

    public void search(int a)
    {
        Application.OpenURL(webs[a]);
    }
}
