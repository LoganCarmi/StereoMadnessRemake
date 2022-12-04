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

    private void OnTriggerEnter2D(Collider2D other) {
        if (bIsShipPortal) {
            Vector3 spriteRotation = spriteTransform.rotation.eulerAngles;
            spriteRotation.z = 0;
            spriteTransform.rotation = Quaternion.Euler(spriteRotation);
            Camera.main.orthographicSize = 5.5f;
            pcPlayerController.bIsShip = true;
            PlayerSprite.sprite = ShipSprite;
        } else {
            Camera.main.orthographicSize = 4.5f;
            pcPlayerController.bIsShip = false;
            PlayerSprite.sprite = CubeSprite;
            Physics2D.gravity = new Vector2(0, -9.81f);
        }
    }
}
