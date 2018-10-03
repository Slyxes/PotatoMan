using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    public float LookRadius = 10f;
    public float enemyrunspeed = 20f;
    private float movedirection;
    private Vector3 Velocity = Vector3.zero;
    private float MovementSmoothing = .05f;

    [SerializeField] Transform player;
    private Rigidbody2D Rigidbody;

	void Start () {
        Rigidbody = GetComponent<Rigidbody2D>();
	}
	void Update () {
        movedirection = CheckWherePlayerIs(player.position, transform.position);
        float distance = Vector3.Distance(player.position, transform.position);
        Vector3 targetVelocity = new Vector2(movedirection * Time.fixedDeltaTime * 10f * enemyrunspeed, Rigidbody.velocity.y);

        if (distance <= LookRadius) {
            Rigidbody.velocity = Vector3.SmoothDamp(Rigidbody.velocity, targetVelocity, ref Velocity, MovementSmoothing);
        }
	}
    private int CheckWherePlayerIs(Vector3 player, Vector3 enemy) {
        if (player.x > enemy.x) {
            return 1;
        }
        else return -1;
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
