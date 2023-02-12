using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] Vector2 bounciness;
    public Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            collision.gameObject.GetComponent<Player>().Damage();
            collision.gameObject.GetComponent<Player>().Bouncy(collision.GetContact(0).normal);
            Bouncy(collision.GetContact(0).normal);
        }

    }

    public void Bouncy(Vector2 HitPoint)
    {
        rg2d.velocity = new Vector2(-bounciness.x * HitPoint.x, bounciness.y);
    }
}
