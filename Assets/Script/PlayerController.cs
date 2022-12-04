using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Déclaration des variables
    public float jumpSpeed = 8f;
    public float playerSpeed;
    public float rotationSpeed;
    public float groundCheckRadius;

    public Transform groundCheck;
    public Transform sprite;
    public LayerMask groundLayer;

    private Rigidbody2D player;
    private bool isGrounded;
    Vector2 position;

    public bool bIsShip = false;

    public int nbCoin = 0;
    
    void Start()
    {
        // Set de la variable du Rigidbody
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Auto moving
        position = transform.position;
        position.x = position.x + playerSpeed * Time.deltaTime;
        transform.position = position;

        // Vérification de si le joueur est en Ship ou en Cube
        if (!bIsShip) {

            // Set quand le joueur touche le sol
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

            if (isGrounded) {
                
                // Modification de la gravité pour un début de saut classique
                Physics2D.gravity = new Vector2(0, -9.81f);

                // Arrondissement de la Rotation du Sprite
                Vector3 spriteRotation = sprite.rotation.eulerAngles;
                spriteRotation.z = Mathf.Round(spriteRotation.z / 90) * 90;
                sprite.rotation = Quaternion.Euler(spriteRotation);

                // Si le bouton "Espace" est appuyé
                if (Input.GetKeyDown(KeyCode.Space)) {

                    // Jump
                    player.velocity = new Vector2(player.velocity.x, jumpSpeed);

                    // Avoir une fin de Jump plus raide et donc moins longue sur l'axe X
                    Physics2D.gravity = new Vector2(0, -12f);

                }

            } else {
                
                // Rotation du sprite
                sprite.Rotate(Vector3.back * rotationSpeed);

            }

        } else {

            // Fonction du "Ship" en désactivant la gravité
            Physics2D.gravity = new Vector2(0, 0);

            // Si le bouton "Flèche Haut" est appuyé
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                
                // Déplacement vers le haut
                player.velocity = new Vector2(player.velocity.x, jumpSpeed / 3);

            }

            // Si le bouton "Flèche Bas" est appuyé
            if (Input.GetKeyDown(KeyCode.DownArrow)) {

                // Déplacement vers le bas
                player.velocity = new Vector2(player.velocity.x, -jumpSpeed / 3);

            }
        }

    }
}
