using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col) {
        Debug.Log("Collision!");
        Destroy(gameObject);
    }

}
