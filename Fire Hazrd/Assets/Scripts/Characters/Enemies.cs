using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Character
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            collision.gameObject.GetComponent<Player>().Damage();
            collision.gameObject.GetComponent<Player>().Bouncy(collision.GetContact(0).normal);
        }

    }

    public override void Damage()
    {
        Health -= 1;
    }
}
