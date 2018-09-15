using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    private int Playerhealth = 5; 

    public void PlayerHealthReduction(int number) {
        Playerhealth -= number;
    }
    public void PlayerHealthIncrease(int number) {
        Playerhealth += number;
    }
    public void PlayerhealthCheck() {
        Debug.Log(Playerhealth);
    }

}
