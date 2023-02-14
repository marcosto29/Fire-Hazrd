using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    float elapsed = 0f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Character>())
        {
            collision.gameObject.GetComponent<Character>().Damage();
            print(collision.gameObject.GetComponent<Character>().Health);
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Character>())
        {
            elapsed += Time.deltaTime;
            if (elapsed >= 2f)
            {
                elapsed %= 2f;
                collision.gameObject.GetComponent<Character>().Damage();
                print(collision.gameObject.GetComponent<Character>().Health);
            }
        }
    }
}
