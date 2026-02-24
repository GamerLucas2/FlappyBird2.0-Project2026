using System;
using UnityEngine;

public class PlayerBehaiviour : MonoBehaviour
{

    [SerializeField] private float jumpForce = 1;
    
    private Rigidbody2D rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            rigidBody.linearVelocity += Vector2.up * jumpForce;
    }
}
