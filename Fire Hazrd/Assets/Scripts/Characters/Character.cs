using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public Vector2 bounciness;
    public int Health;
    public Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public abstract void Damage();
    public void Bouncy(Vector2 HitPoint)
    {
        rg2d.velocity = new Vector2(-bounciness.x * HitPoint.x, bounciness.y);
    }
}
