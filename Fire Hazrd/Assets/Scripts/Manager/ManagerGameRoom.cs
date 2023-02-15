using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGameRoom : Manager
{
    public GameObject key;
    bool win;
    public Enemies[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        win = false;
        key.SetActive(false);
        if (Global.flags[1] == true)
        {
            fire.GetComponent<Animator>().SetTrigger("Burn");
        }
        ActiveLayer = MainCharacter.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        ActiveLayers(ActiveLayer);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Enemies e in enemies)
        {
            if (e.isActiveAndEnabled) break;
            else win = true;
        }
        if (win == true)
        {
            key.SetActive(true);
            key.GetComponent<Animator>().SetTrigger("sparkle");
        }
   
    }
}
