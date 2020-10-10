using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpHeight = 10f;
    //[SerializeField] float jumpSpeed = 5f;

    [SerializeField]private bool isGrounded = false;

    Vector3 vector;

    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        vector.x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.position += vector;

        if (Input.GetButton("Jump") && isGrounded)
        {
            //Debug.Log("Jump");
            isGrounded = false;
            Jump();
        }
    }

    private void Jump()
    {
        body.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
