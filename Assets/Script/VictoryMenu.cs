using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public GameObject VictoryMenuUI;
    public AudioSource AmbianceSonore;

    // Fonction pour Quitter le jeu depuis le menu de Victoire
    public void Quit() {
        Application.Quit();                               // Fonctionne en jeu
        UnityEditor.EditorApplication.isPlaying = false;  // Fonctionne sur l'éditeur
    }

    // Fonction pour Restart le niveau
    public void Restart() {
        SceneManager.LoadScene("Level"); // Reload du niveau
        Time.timeScale = 1f;             // Remise du temps de la manière classique
    }
}
