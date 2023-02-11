using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    public float direction = 0f;
    private Rigidbody2D player;

    [SerializeField] private LayerMask layer;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);//se aplica una velocidad a la dirección que vaya el jugador
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);//para que no haya deslizamiento
        }
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
    }

    private bool IsGrounded()
    {
        PolygonCollider2D b = this.GetComponent<PolygonCollider2D>();
        return Physics2D.BoxCast(b.bounds.center, b.bounds.size, 0f, Vector2.down, .1f, layer);
    }
}
