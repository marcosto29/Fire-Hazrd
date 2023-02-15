using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGameBasement : Manager
{
    private void Start()
    {
        if(Global.flags[2] == true)
        {
            print("SI");
            fire.GetComponent<Animator>().SetTrigger("Burn");
        }
        ActiveLayer = MainCharacter.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        ActiveLayers(ActiveLayer);
    }
    void Update()
    {

    }

    
}