using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField] RectTransform Healthbarfill;
    [SerializeField] public Transform Player;


    private void FixedUpdate() {
        SetHealthAmount(PlayerHealth.Playerhealth/100);
    }
    
    void SetHealthAmount(float amount) {
        Healthbarfill.localScale = new Vector3(amount, 1f, 1f);
    }
}
