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
        Health = 6;
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
            case 1:
                HealthUI.sprite = Hearts[0];
                break;
            case 2:
                HealthUI.sprite = Hearts[0];
                break;
            case 3:
                HealthUI.sprite = Hearts[1];
                break;
            case 4:
                HealthUI.sprite = Hearts[1];
                break;
            case 5:
                HealthUI.sprite = Hearts[2];
                break;
            case 6:
                HealthUI.sprite = Hearts[2];
                break;

        }
    }
}
