using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col) {
        GameObject.Find("Player").GetComponent<PlayerHealth>().PlayerHealthIncrease(1);
        Destroy(gameObject);
        GameObject.Find("Player").GetComponent<PlayerHealth>().PlayerhealthCheck();
    }

}
