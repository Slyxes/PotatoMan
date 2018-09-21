using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField] RectTransform Healthbarfill;
    [SerializeField] public Transform Player;
    private PlayerHealth playerhealth;

    private void Awake() {
        playerhealth = Player.GetComponent<PlayerHealth>();
    }

    private void FixedUpdate() {
        SetHealthAmount(playerhealth.GetHealthpct());
    }
    
    void SetHealthAmount(float _amount) {
        Healthbarfill.localScale = new Vector3(_amount, 1f, 1f);
        Debug.Log(_amount);
    }
}
