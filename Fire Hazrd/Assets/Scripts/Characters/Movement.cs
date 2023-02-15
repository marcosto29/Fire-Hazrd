using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    [SerializeField] private float distance;

    [SerializeField] private float limit;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(speed, rb.velocity.y);

        distance += 1;

        if (distance >= limit)//cuando alcance esta distancia se gira
        {
            distance = 0;
            Turn();
        }
    }

    private void Turn()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        speed *= -1;
    }
}
