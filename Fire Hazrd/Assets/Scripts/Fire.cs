using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    float elapsed = 0f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Player>().Health -= 1;
        print(collision.gameObject.GetComponent<Player>().Health);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        elapsed += Time.deltaTime;
        if(elapsed >= 2f)
        {
            elapsed %= 2f;
            collision.gameObject.GetComponent<Player>().Health -= 1;
            print(collision.gameObject.GetComponent<Player>().Health);
        }       
    }
}
