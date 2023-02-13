using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGameRoom : MonoBehaviour
{
    string ActiveLayer;
    public Player MainCharacter;
    public GameObject[] Layers;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        ActiveLayer = MainCharacter.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        ActiveLayers(ActiveLayer);
    }

    // Update is called once per frame
    void Update()
    {

        //key = GameObject.Find("key");

        bool win = true;
        foreach (Transform e in this.transform)
        {
            if (e.GetComponent<Enemies>())
            {

                if (e.gameObject.GetComponent<Enemies>().Health <= 0)
                    e.gameObject.SetActive(false);

                else win = false;

            }
        }
        if (win == true)
        {
            print("h");
            key.SetActive(true);
        }
        /*  

                }

                if (win == true)
                {
                  key.SetActive(true);

                }
                //cuando no hay enemigos lo detecta y aparece la llave
        */



    }


    public void ActiveLayers(string Layer)
    {
        foreach (GameObject l in Layers)
        {
            if (l.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == Layer)
            {
                foreach (Transform child in l.transform)
                {
                    if (child.GetComponent<Collider2D>())
                    {
                        Collider2D[] colList = child.transform.GetComponentsInChildren<Collider2D>();
                        foreach (Collider2D c in colList)
                        {
                            c.enabled = true;
                        }
                    }
                }
            }
            else
            {
                foreach (Transform child in l.transform)
                {
                    if (child.GetComponent<Collider2D>())
                    {
                        Collider2D[] colList = child.transform.GetComponentsInChildren<Collider2D>();
                        foreach (Collider2D c in colList)
                        {
                            c.enabled = false;
                        }
                    }
                }
            }
        }
    }
}
