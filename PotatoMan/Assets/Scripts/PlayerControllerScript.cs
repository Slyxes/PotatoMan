﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

    [SerializeField] private float JumpForce = 700f;
    [SerializeField] private float MovementSmoothing = .05f;
    [SerializeField] private bool IsAdmincontrol = true;
    [SerializeField] Transform GroundCheck;
    [SerializeField] private LayerMask WhatIsGround;

    private bool Grounded;
    const float GroundedRadius = .2f;
    private bool FacingRight = true;
    private Vector3 Velocity = Vector3.zero;
    private Rigidbody2D OceanmanRigidbody2D;
    private bool HasJumped = false;

    private void Awake() {
        OceanmanRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate() {
        bool wasGrounded = Grounded;
        Grounded = false;

        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, WhatIsGround);
        for (int i = 0; i < colliders.Length; i++) {
            if (colliders[i].gameObject != gameObject) {
                Grounded = true;
                HasJumped = false;
                    }
        }
    }

    public void Move(float move, bool jump) {
        
        Vector3 targetVelocity = new Vector2(move * 10f, OceanmanRigidbody2D.velocity.y);
        OceanmanRigidbody2D.velocity = Vector3.SmoothDamp(OceanmanRigidbody2D.velocity, targetVelocity, ref Velocity, MovementSmoothing);
        
        if (jump && !Grounded && !HasJumped || jump && IsAdmincontrol) {
            if (!IsAdmincontrol) {
                HasJumped = true;
            }
            OceanmanRigidbody2D.AddForce(new Vector2(0f, JumpForce)); 
        }
    }

    
}
