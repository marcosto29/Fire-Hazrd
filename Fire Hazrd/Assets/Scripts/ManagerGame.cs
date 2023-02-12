using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    string ActiveLayer;
    int ActiveLayerId;
    public Player MainCharacter;
    public GameObject[] Layers;
    // Start is called before the first frame update
    void Start()
    {
        ActiveLayer = MainCharacter.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        ActiveLayerId = MainCharacter.gameObject.GetComponent<SpriteRenderer>().sortingLayerID;
        ActiveLayers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveLayers()
    {
        foreach(GameObject l in Layers)
        {
            if(l.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == ActiveLayer)
            {
                foreach(Transform child in l.transform)
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
                        foreach(Collider2D c in colList)
                        {
                            c.enabled = false;
                        }
                    }
                }
            }
        }
    }
}
