using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public AudioManager Audio;
    public float launchForce;
    //public GameObject player;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * launchForce;
        Audio.Play("Boing");
    }
    private void Update()
    {
        //Vector2 vector = player.transform.position - this.transform.position;
        //Debug.DrawRay(player.transform.position, vector * launchForce, Color.red);
        //Debug.DrawRay(player.transform.position, player.GetComponent<Rigidbody2D>().velocity, Color.green);
    }
    
}
