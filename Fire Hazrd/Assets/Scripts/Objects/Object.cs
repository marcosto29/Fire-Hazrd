using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject InteractKey;

    public string Scene;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        InteractKey.gameObject.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        InteractKey.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (InteractKey.gameObject.activeInHierarchy){
            if (Input.GetKeyDown(KeyCode.I))
            {
                print("aaaaaa");
                GameObject.Find("LevelLoader").GetComponent<Scenes>().playScene(Scene);
            }
        }
    }
}
