using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    public float jumpSpeed = 8f;
    public float playerSpeed;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isGrounded;
    Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 7.0f * horizontal * Time.deltaTime;
        position.y = position.y + 10.0f * vertical * Time.deltaTime;
        transform.position = position;

        */
        position = transform.position;
        position.x = position.x + playerSpeed * Time.deltaTime;
        transform.position = position;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }

    }



}
