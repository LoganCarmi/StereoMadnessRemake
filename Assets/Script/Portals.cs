using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{
    public Transform spriteTransform;
    public PlayerController pcPlayerController;
    public bool bIsShipPortal;
    public SpriteRenderer PlayerSprite;
    public Sprite CubeSprite;
    public Sprite ShipSprite;

    // Si le joueur passe le portail
    private void OnTriggerEnter2D(Collider2D other) {
        
        // Si le portail est un portail pour le Ship 
        if (bIsShipPortal) {
            
            // Reset de la Rotation du joueur
            Vector3 spriteRotation = spriteTransform.rotation.eulerAngles;
            spriteRotation.z = 0;
            spriteTransform.rotation = Quaternion.Euler(spriteRotation);

            Camera.main.orthographicSize = 5.5f; // Dézoom de la Main Camera
            pcPlayerController.bIsShip = true;   // Changement des contrôles sur le joueur
            PlayerSprite.sprite = ShipSprite;    // Changement du Sprite
        } else {
            Camera.main.orthographicSize = 4.5f;         // Reset du Zoom de la Main Camera
            pcPlayerController.bIsShip = false;          // Reset des contrôles du joueur
            PlayerSprite.sprite = CubeSprite;            // Reset du Sprite du joueur
            Physics2D.gravity = new Vector2(0, -9.81f);  // Reset de la gravité
        }
    }
}
