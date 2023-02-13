using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    public float direction = 0f;
    private Rigidbody2D player;

    string[] Layers = { "Back", "Medium", "Front" };
    string CurrentLayer;

    [SerializeField] private LayerMask layer;

    public ManagerGame manager;

    public Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        CurrentLayer = this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animate.SetTrigger("Stop");
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);//se aplica una velocidad a la dirección que vaya el jugador
            animate.SetTrigger("Walk");
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            animate.SetTrigger("Walk");
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);//para que no haya deslizamiento
        }

        direction = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Vertical"))
        {
            if (direction < 0f)
            {
                int index = System.Array.IndexOf(Layers, CurrentLayer);
                if(index != 2)
                {
                    CurrentLayer = Layers[index + 1];
                }
                print(CurrentLayer);
                animate.SetTrigger("WalkF");
            }
            else if (direction > 0f)
            {
                int index = System.Array.IndexOf(Layers, CurrentLayer);
                if (index != 0)
                {
                    CurrentLayer = Layers[index - 1];
                }
                print(CurrentLayer);
                animate.SetTrigger("WalkB");
            }

            this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = CurrentLayer;

            manager.ActiveLayers(CurrentLayer);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            animate.SetTrigger("Jump");
        }
    }

    private bool IsGrounded()
    {
        Collider2D b = this.GetComponent<Collider2D>();
        return Physics2D.BoxCast(b.bounds.center, b.bounds.size, 0f, Vector2.down, .1f, layer);
    }
}
