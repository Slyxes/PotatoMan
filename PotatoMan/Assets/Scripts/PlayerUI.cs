using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField] RectTransform Healthbarfill;
    [SerializeField] public Transform Player;


    private void FixedUpdate() {
        //Hämtar hur mycket HP spelaren har
        SetHealthAmount(PlayerHealth.Playerhealth/100);
    }
    
    void SetHealthAmount(float amount) {
        //Fixar Healthbaren, hur mycket som är fyllt
        Healthbarfill.localScale = new Vector3(amount, 1f, 1f);
    }
}
