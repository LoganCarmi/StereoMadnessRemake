using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryFlag : MonoBehaviour
{
    public AudioSource AmbianceSonore;
    public GameObject VictoryMenuUI;

    // Lorsque le joueur touche la pièce de Victoire
    void OnTriggerEnter2D(Collider2D col) {
        
        AmbianceSonore.Pause();         // Pause la musique
        VictoryMenuUI.SetActive(true);  // Mets le Menu de Victoire en visuel
        Time.timeScale = 0f;            // Pause le jeu
    }
}
