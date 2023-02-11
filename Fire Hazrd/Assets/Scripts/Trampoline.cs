using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float launchForce;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.rigidbody.velocity = Vector2.up * launchForce;
    }
}
