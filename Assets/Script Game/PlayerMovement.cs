using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public bool isJumping = false;

    private float moveInput;
    private Rigidbody2D rb2d;

    public ScoreManager sm;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }// Start
    
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        // เคลื่อนที่ซ้าย-ขวา
        rb2d.linearVelocity = new Vector2(moveInput * speed, rb2d.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jumpForce));

        }

    }// Update
    
    // เมื่อตัวละครสัมผัสพื้น
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        } // Collision Ground

        if (other.gameObject.CompareTag("Not"))
        {
            Debug.Log("Hit!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reset Game
            print("Reset Game");
            
        } // Collision Obstacle hit to Reset Game.
        
    }//OnCollisionEnter2D
    
    // เมื่อตัวละครออกจากพื้น
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
        
    }//OnCollisionExit2D
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gems"))
        {
            
            Debug.Log("Trigger!!");
            Destroy(other.gameObject);
            sm.ScoreCount++;
            
        }
        
    }//OnTriggerEnter2D Gems Points
    
}//PlayerMovement
