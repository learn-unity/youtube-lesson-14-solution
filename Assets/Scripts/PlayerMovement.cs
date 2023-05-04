using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed;
        float moveY = Input.GetAxis("Vertical") * speed;

        _rigidbody.velocity = new Vector2(moveX, moveY);
    }
}
