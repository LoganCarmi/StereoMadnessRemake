using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionBar : MonoBehaviour
{
    public GameObject Player;
    public GameObject Flag;

    void Update() {
        //  Update la Progress Bar en suivant la formule : 
        // (Position du joueur + décalage depuis la position x = 0) / (Position du flag + décalage depuis la position x = 0 )
        transform.localScale = new Vector3 ((Player.transform.position.x + 14.39f) / (Flag.transform.position.x + 14.39f) , 1, 1);
    }
}
