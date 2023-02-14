using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    public float direction = 0f;
    private Rigidbody2D player;
    public bool move;

    string[] Layers = { "Back", "Medium", "Front" };
    string CurrentLayer;

    [SerializeField] private LayerMask layer;

    public ManagerGame manager;

    public Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        move = true;
        CurrentLayer = this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animate.ResetTrigger("Jump");
        animate.ResetTrigger("Attack");
        if (move)
        {
            direction = Input.GetAxis("Horizontal");

            if (direction > 0f)
            {
                animate.SetBool("Walk", true);
                player.velocity = new Vector2(direction * speed, player.velocity.y);//se aplica una velocidad a la dirección que vaya el jugador
                this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (direction < 0f)
            {
                animate.SetBool("Walk", true);
                player.velocity = new Vector2(direction * speed, player.velocity.y);
                this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                animate.SetBool("Walk", false);
                animate.SetBool("Front", false);
                animate.SetBool("Back", false);
                player.velocity = new Vector2(0, player.velocity.y);//para que no haya deslizamiento
            }

            direction = Input.GetAxis("Vertical");

            if (Input.GetButtonDown("Vertical"))
            {
                if (direction < 0f)
                {
                    animate.SetBool("Front", true);
                    int index = System.Array.IndexOf(Layers, CurrentLayer);
                    
                    if (index != 2)
                    {
                        this.gameObject.transform.localScale *= new Vector2(1.2f, 1.2f);
                        CurrentLayer = Layers[index + 1];
                    }
                    print(CurrentLayer);
                }
                else if (direction > 0f)
                {

                    int index = System.Array.IndexOf(Layers, CurrentLayer);
                    animate.SetBool("Back", true);
                    if (index != 0)
                    {
                        this.gameObject.transform.localScale *= new Vector2(10/12f, 10/12f);
                        CurrentLayer = Layers[index - 1];

                    }
                }

                this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = CurrentLayer;

                manager.ActiveLayers(CurrentLayer);
            }

            if (Input.GetButtonDown("Jump") && IsGrounded())
            {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);
                animate.SetTrigger("Jump");
            }
            if (Input.GetButtonDown("Fire1"))
            {
                animate.SetTrigger("Attack");
            }
        }     
    }
    

    private bool IsGrounded()
    {
        Collider2D b = this.GetComponent<Collider2D>();
        return Physics2D.BoxCast(b.bounds.center, b.bounds.size, 0f, Vector2.down, .1f, layer);
    }
}
