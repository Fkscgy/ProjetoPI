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
        Destroy(this.gameObject,5f);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right*velocity,ForceMode2D.Impulse);

    }
    // void FixedUpdate()
    // {
    //     rb.AddForce(transform.right*velocity,ForceMode2D.Impulse);
    // }

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
