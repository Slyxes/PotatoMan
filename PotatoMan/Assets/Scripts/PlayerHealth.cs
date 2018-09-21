using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    private float Playerhealth;

    private void Awake() {
        Playerhealth = 100;
    }

    public void PlayerHealthReduction(float number) {
        Playerhealth -= number;
    }
    public void PlayerHealthIncrease(float number) {
        Playerhealth += number;
    }
    public float GetHealthpct() {
        Debug.Log("curerntplayerhealth" + Playerhealth);
        return Playerhealth / 100;
    }
    public void PlayerhealthCheck() {
        Debug.Log(Playerhealth);
    }

}
