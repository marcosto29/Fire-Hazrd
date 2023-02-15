using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    public Scenes scenemanager;
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
                scenemanager.playScene("Defeat");
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

    public void Bouncy(Vector2 HitPoint)
    {
        StartCoroutine(Stop());
        rg2d.velocity = new Vector2(-bounciness.x * HitPoint.x, bounciness.y);
    }

    IEnumerator Stop()
    {
        this.gameObject.GetComponent<PlayerController>().move = false;
        yield return new WaitForSeconds(1);
        this.gameObject.GetComponent<PlayerController>().move = true;
    }

}
