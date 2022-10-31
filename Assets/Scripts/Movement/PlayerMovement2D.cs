using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [SerializeField] private float jumpingPower = 16f;
    [SerializeField] private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private bool isFacingRight = true;
    private float horizontal;
    private bool isUpJump;
    private bool isDownJump;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (isUpJump == false)
            isUpJump = Input.GetButtonDown("Jump") && IsGrounded();
        if (isDownJump == false)
            isDownJump = Input.GetButtonUp("Jump") && rb.velocity.y > 0f;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (isUpJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            isUpJump = false;
        }
        if (isDownJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            isDownJump = false;
        }

        Flip();
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}