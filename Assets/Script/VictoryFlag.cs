using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryFlag : MonoBehaviour
{
    public AudioSource AmbianceSonore;
    public GameObject VictoryMenuUI;

    void OnTriggerEnter2D(Collider2D col) {
        AmbianceSonore.Pause();
        VictoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
