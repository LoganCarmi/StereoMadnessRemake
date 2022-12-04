using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    // Caméra qui follow le joueur
    void Update()
    {
        // Update de la position de la caméra avec un certain décallage
        transform.position = new Vector3(player.position.x + 4.4f, player.position.y + 0.5f, -10);
    }
}
