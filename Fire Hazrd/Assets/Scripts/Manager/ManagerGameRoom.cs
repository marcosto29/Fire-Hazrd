using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGameRoom : Manager
{
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
            key.SetActive(true);
            key.GetComponent<Animator>().SetTrigger("Sparkle");
        }
    }
}
