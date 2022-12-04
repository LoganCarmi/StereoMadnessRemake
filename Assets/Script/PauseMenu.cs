using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool bIsPaused = false;
    public GameObject PauseMenuUI;
    public AudioSource AmbianceSonore;

    // Détection de quand le joueur appuie sur le bouton "P"
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {

            if (bIsPaused)   { Resume(); }
            
            else            { Pause(); }

        }
    }

    // Resume le jeu
    public void Resume() {

        AmbianceSonore.UnPause();     // Resume la musique
        PauseMenuUI.SetActive(false); // Retire l'affichage du Menu de Pause
        Time.timeScale = 1f;          // Resume le temps
        bIsPaused = false;           
    }

    // Pause le jeu
    void Pause() {
        AmbianceSonore.Pause();
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        bIsPaused = true;
    }
}
