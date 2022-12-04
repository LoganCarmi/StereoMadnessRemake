using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour 
{
    // Lorsque le joueur touche un Spike
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerController controller = col.GetComponent<PlayerController>();
        controller.nbCoin = 0;            // Reset de son nombre de Coins
        SceneManager.LoadScene("Level");  // Reload du niveau
    }
}
