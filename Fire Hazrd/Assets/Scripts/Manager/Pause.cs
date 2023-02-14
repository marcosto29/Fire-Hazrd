using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject menuPause;

    public void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            pause();
    }
    public void pause()
    {

        Time.timeScale = 0f;
        menuPause.SetActive(true);
        

    }

    public void resume()
    {
        Time.timeScale = 1f;
        menuPause.SetActive(false);
        
    }

    

}
