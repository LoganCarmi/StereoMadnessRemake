using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUpdate : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public PlayerController pcPlayerController;
    
    void Update() {

        // Update du Text pour afficher les coins
        Text.text = "Coins : " + pcPlayerController.nbCoin;
    
    }
}
