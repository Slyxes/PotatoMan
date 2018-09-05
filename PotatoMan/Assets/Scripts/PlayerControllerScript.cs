using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

    [SerializeField] private float JumpForce = 700f;
    [SerializeField] private float MovementSmoothing = .05f;
    [SerializeField] private bool AirControl = true;

    private bool FacingRight = true;
    private Vector3 Velocity = Vector3.zero;
    private Rigidbody2D OceanmanRigidbody2D;

    private void Awake() {
        OceanmanRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move(float move, bool jump) {
        if (AirControl) {
            Vector3 targetVelocity = new Vector2(move * 10f, OceanmanRigidbody2D.velocity.y);
            OceanmanRigidbody2D.velocity = Vector3.SmoothDamp(OceanmanRigidbody2D.velocity, targetVelocity, ref Velocity, MovementSmoothing);

            if (move > 0 && !FacingRight) {
                Flip();
            }
            else if(move < 0 && FacingRight) {
                Flip();
            }
        }
        if (jump) {
            OceanmanRigidbody2D.AddForce(new Vector2(0f, JumpForce));
        }
    }
    private void Flip() {
        FacingRight = !FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
}
