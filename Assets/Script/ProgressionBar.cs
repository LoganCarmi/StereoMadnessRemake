using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionBar : MonoBehaviour
{
    public GameObject Player;
    public GameObject Flag;

    void Update() {
        transform.localScale = new Vector3 ((Player.transform.position.x + 14.39f) / Flag.transform.position.x, 1, 1);
    }
}
