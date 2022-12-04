using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerController controller = col.GetComponent<PlayerController>();
        controller.nbCoin = 0;
        SceneManager.LoadScene("Level");
    }
}
