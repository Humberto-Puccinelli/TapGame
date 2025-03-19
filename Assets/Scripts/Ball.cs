using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public float jumpForce = 120f;
    public int scorePlayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataform"))
        {
            scorePlayer++;
            GameController.instance.updateScoreText(scorePlayer);
           // Jump();
        }else if (collision.gameObject.CompareTag("Launcher"))
        {
            Launch();
        }
    }
    
    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    
    void Launch()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 10);
        rb.AddForce(Vector2.up * jumpForce, (ForceMode2D.Impulse + 55));
    }
    
    void QuickWall()
    {
        rb.linearVelocity = new Vector2((rb.linearVelocity.x * -1), (rb.linearVelocity.y * -1));
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
