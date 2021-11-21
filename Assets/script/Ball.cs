using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        float hitFactor(Vector2 ballpos, Vector2 racketPos, float racketWidth)
        {
            return (ballpos.x - racketPos.x) / racketWidth;
        }
        void OnTriggerEnter2D(Collider2D collision)

        {
            if (collision.gameObject.name == "racket")
            {
                float x = hitFactor(transform.position,
                    collision.transform.position,
                    collision.bounds.size.x);
                Vector2 dir = new Vector2(x, 1).normalized;
                GetComponent<Rigidbody2D>().velocity = dir * speed;
            }
        }

    }
}
