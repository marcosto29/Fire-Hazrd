using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    public Sprite[] Hearts;
    public Image HealthUI;
    // Start is called before the first frame update
    void Start()
    {
        Health = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Damage()
    {
        Health -= 1;
        switch (Health)
        {
            case 0:
                //Cargar la escena de derrota o reiniciar el nivel
                break;
            case 1:
                HealthUI.sprite = Hearts[0];
                break;
            case 2:
                HealthUI.sprite = Hearts[1];
                break;
            case 3:
                HealthUI.sprite = Hearts[2];
                break;
        }
    }
}
