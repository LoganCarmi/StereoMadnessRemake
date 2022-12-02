using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool bIsPaused = false;
    public GameObject PauseMenuUI;
    public AudioSource AmbianceSonore;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {

            if (bIsPaused)   { Resume(); }
            
            else            { Pause(); }

        }
    }

    public void Resume() {
        AmbianceSonore.UnPause();
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        bIsPaused = false;
    }

    void Pause() {
        AmbianceSonore.Pause();
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        bIsPaused = true;
    }
}
