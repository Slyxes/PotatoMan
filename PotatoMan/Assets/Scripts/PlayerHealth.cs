using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] Transform player;

    bool Killzonealreadyhitcheck = false;
    public static float Playerhealth = 100;

    private void PlayerHealthReduction(float number) {
        Playerhealth -= number;
    }
    private void PlayerHealthIncrease(float number) {
        Playerhealth += number;
    }

    public void PlayerhealthCheck() {
        Debug.Log(Playerhealth);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "HealthPickup" && Killzonealreadyhitcheck == false) {
            if (Killzonealreadyhitcheck == false) {
                PlayerHealthIncrease(20);
                Destroy(collision.gameObject);
                Killzonealreadyhitcheck = true;
                PlayerhealthCheck();
            }
        }
        if (collision.gameObject.tag == "KillZone" && Killzonealreadyhitcheck == false) {
            if (Killzonealreadyhitcheck == false) {
                PlayerHealthReduction(20);
                player.transform.position = new Vector3(-4, 2, 0);
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                Killzonealreadyhitcheck = true;
                PlayerhealthCheck();
            }
        }
        if (collision.gameObject.tag == "WalkableGround") {
            Killzonealreadyhitcheck = false;
        }
    }
}
