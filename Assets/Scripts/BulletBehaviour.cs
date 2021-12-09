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
}
