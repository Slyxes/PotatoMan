using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public PlayerControllerScript controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool HitEscape = false;

    // Update is called once per frame
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
        if (Input.GetButtonDown("Cancel")) {
            HitEscape = true;
        }
    }

    private void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
        controller.Esc(HitEscape);
        HitEscape = false;
    }
}
