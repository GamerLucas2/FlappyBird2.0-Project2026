using System;
using UnityEngine;

public class PlayerBehaiviour : MonoBehaviour
{

    [SerializeField] private float jumpForce = 1f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rigidBody;
    
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
            rigidBody.linearVelocity = Vector2.up * jumpForce;
        
        transform.rotation=Quaternion.Euler(0f,0f, rigidBody.linearVelocity.y*rotationSpeed);
    }
}
