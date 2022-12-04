using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private AudioSource _audioSource;
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        if (_audioSource == null) {
            Debug.Log("Audio Source is Null");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerController controller = col.GetComponent<PlayerController>();
        controller.nbCoin = 0;
        SceneManager.LoadScene("Level");
    }
}
