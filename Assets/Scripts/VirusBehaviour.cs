using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VirusBehaviour : MonoBehaviour
{
    [SerializeField]
    float velocity;
    Rigidbody2D rb;
    ScoreController sc;
    GameController gc;
    
    void Start()
    {
        gc = GameObject.FindObjectOfType<GameController>();
        sc = GameObject.FindObjectOfType<ScoreController>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0f,velocity),ForceMode2D.Force);
        StartCoroutine(Flip());
    }
    void Update()
    {
        transform.Translate(-transform.up*velocity*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch(col.tag)
        {
            case "Ground":
                Destroy(this.gameObject);
                gc.GameOver();
            break;
            case "Y":
                sc.Increase(1);
                Destroy(col.gameObject);
                Destroy(this.gameObject);
            break;
        }
    }
    IEnumerator Flip()
    {
        // transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
        transform.Rotate(new Vector3(0f,0f,0f),Space.World);
        yield return new WaitForSeconds(0.5f);
        transform.Rotate(new Vector3(0f,180f,0f),Space.World);
        // transform.rotation = Quaternion.Euler(new Vector3(0f,180f,0f));
        StartCoroutine(Flip());
    }
}
