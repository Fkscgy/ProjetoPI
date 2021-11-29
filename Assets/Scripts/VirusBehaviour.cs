using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehaviour : MonoBehaviour
{
    [SerializeField]
    float velocity;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0f,velocity),ForceMode2D.Force);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch(col.tag)
        {
            case "Ground":
                Destroy(this.gameObject);
                // GameManager.GameOver();  
            break;
        }
    }
}
