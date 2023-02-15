using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Character
{
    public string sound;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            audio.Play("Hit");
            collision.gameObject.GetComponent<Player>().Damage();
            collision.gameObject.GetComponent<Player>().Bouncy(collision.GetContact(0).normal);
        }

    }

    public override void Damage()
    {
        audio.Play(sound);
        Health -= 1;
        if (Health <= 0) this.gameObject.SetActive(false);
    }
}
