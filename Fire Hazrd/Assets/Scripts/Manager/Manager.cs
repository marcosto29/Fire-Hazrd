using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Manager : MonoBehaviour
{
    public string ActiveLayer;
    public Player MainCharacter;
    public GameObject[] Layers;
    public GameObject fire;
    public bool loose;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     

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
