using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int Health = 20;
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Health <=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.relativeVelocity.magnitude > 37)
            {
                sr.color = Color.red;
                Health -= 6;
                return;
            }
            if (collision.relativeVelocity.magnitude > 25)
            {
                Health -= 5;
            }
        }
        

        
    }
}
