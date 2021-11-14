using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField]
    float velocity;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(velocity,0f),ForceMode2D.Force);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch(col.tag)
        {
            case "Ground":
                Destroy(this.gameObject);  
            break;
            case "Virus":
                Destroy(col.gameObject);
                Destroy(this.gameObject);
                // GameManager.Point();
            break;
        }
    }
}
