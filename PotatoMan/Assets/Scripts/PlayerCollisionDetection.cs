using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour {

    [SerializeField] public PlayerHealth playerhealth;
    [SerializeField] Transform player;

    bool Killzonealreadyhitcheck = false;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "HealthPickup") {
            playerhealth.PlayerHealthIncrease(40);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "KillZone" && Killzonealreadyhitcheck == false) {
            if (Killzonealreadyhitcheck == false) {
                playerhealth.PlayerHealthReduction(20);
                player.transform.position = new Vector3(-4, 2, 0);
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                Killzonealreadyhitcheck = true;
                playerhealth.PlayerhealthCheck();
            }
        }
        if (collision.gameObject.tag == "WalkableGround") {
            Killzonealreadyhitcheck = false;
        }
    }
}
