using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGameBasement : Manager
{
    private void Start()
    {
        if (GlobalInventory.flags[2] == true)
        {
            fire.GetComponent<Animator>().SetTrigger("Burn");
        }
        ActiveLayer = MainCharacter.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        ActiveLayers(ActiveLayer);
    }
    void Update()
    {
        
    }

    
}