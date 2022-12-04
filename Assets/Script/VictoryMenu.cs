using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public GameObject VictoryMenuUI;
    public AudioSource AmbianceSonore;

    public void Quit() {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Restart() {
        SceneManager.LoadScene("Level");
        Time.timeScale = 1f;
    }
}
