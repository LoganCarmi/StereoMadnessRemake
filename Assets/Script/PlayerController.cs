using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D player;
    public float jumpSpeed = 8f;
    public float playerSpeed;
    public float rotationSpeed;

    public Transform groundCheck;
    public Transform sprite;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isGrounded;
    Vector2 position;

    public bool bIsShip = false;

    public int nbCoin = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        position.x = position.x + playerSpeed * Time.deltaTime;
        transform.position = position;


        if (!bIsShip) {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

            if (isGrounded) {

                Physics2D.gravity = new Vector2(0, -9.81f);
                Vector3 spriteRotation = sprite.rotation.eulerAngles;
                spriteRotation.z = Mathf.Round(spriteRotation.z / 90) * 90;
                sprite.rotation = Quaternion.Euler(spriteRotation);


                if (Input.GetKeyDown(KeyCode.Space)) {

                    player.velocity = new Vector2(player.velocity.x, jumpSpeed);
                    Physics2D.gravity = new Vector2(0, -12f);

                }

            } else {
                sprite.Rotate(Vector3.back * rotationSpeed);
            }

        } else {
            Physics2D.gravity = new Vector2(0, 0);

            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed / 3);
            }


            if (Input.GetKeyDown(KeyCode.DownArrow)) {
                player.velocity = new Vector2(player.velocity.x, -jumpSpeed / 3);
            }
        }

    }
}
