using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGameRoom : Manager
{
    public GameObject key;
    bool win;
    public Enemies[] enemies;
    int Point;
    // Start is called before the first frame update
    private void Start()
    {
        win = false;
        key.SetActive(false);

        if (GlobalInventory.flags[1] == true)
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
            if (e.isActiveAndEnabled == false) Point++;
        }
        if (Point == enemies.Length && GlobalInventory.flags[1] == false) key.SetActive(true);
        else Point = 0;
    }
}
