using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private bool faceRight = true;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        if (moveX > 0 && !faceRight)
        {
            flip();
        }
        if (moveX < 0 && faceRight)
        { flip(); }

        

    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
