using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] Transform player;
    [SerializeField] Transform enemy;

    private float EnemycollisionOffset = 0.7f;

    bool Killzonealreadyhitcheck = false;
    public static float Playerhealth = 100;
    //Function för att ta bort Health från spelaren
    private void PlayerHealthReduction(float number) {
        Playerhealth -= number;
    }
    //Function för att ge spelaren Health
    private void PlayerHealthIncrease(float number) {
        Playerhealth += number;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //Om du tar upp health
        if (collision.gameObject.tag == "HealthPickup" && Killzonealreadyhitcheck == false) {
            if (Killzonealreadyhitcheck == false) {
                PlayerHealthIncrease(20);
                Destroy(collision.gameObject);
                Killzonealreadyhitcheck = true;
            }
        }
        //Om du faller utanför banan
        if (collision.gameObject.tag == "KillZone" && Killzonealreadyhitcheck == false) {
            if (Killzonealreadyhitcheck == false) {
                PlayerHealthReduction(20);
                playerRespawn();
                Killzonealreadyhitcheck = true;
            }
        }
        //Reset för att contra flera kallelser
        if (collision.gameObject.tag == "WalkableGround") {
            Killzonealreadyhitcheck = false;
        }
        if (collision.gameObject.tag == "Enemy" && Killzonealreadyhitcheck == false) {
            //Om du är över fienden så försvinner han
            if (collision.transform.position.y + EnemycollisionOffset < player.transform.position.y) {
                Destroy(enemy.gameObject);
            }
            //Om du inte är över tar du damage och börjar om från början
            else {
                PlayerHealthReduction(10);
                playerRespawn();
            }
        }
    }
    //Spelare restart position + nollställer momentum osv
    private void playerRespawn() {
        player.transform.position = new Vector3(-4, 2, 0);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
