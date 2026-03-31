using System;
using UnityEngine;

public class PlayerBehaiviour : MonoBehaviour
{

    [SerializeField] private float jumpForce = 1f;
    [SerializeField] private float rotationSpeed = 10f;
    private bool isAllive = true;
    
    // [SerializeField] private GameManager gameManager;
    private Rigidbody2D rigidBody;
    
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAllive)
            rigidBody.linearVelocity = Vector2.up * jumpForce;
        
        transform.rotation=Quaternion.Euler(0f,0f, rigidBody.linearVelocity.y*rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAllive = false;
        GameManager.Instance.GameOver();
        
        if (collision.gameObject.CompareTag("Ground"))
            Time.timeScale = 0;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.AddPoint();
    }
}
