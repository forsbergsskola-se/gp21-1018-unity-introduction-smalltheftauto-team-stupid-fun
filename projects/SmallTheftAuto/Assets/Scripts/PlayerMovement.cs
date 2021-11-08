using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Camera cam;
    
    private Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;

    private void Awake()
    {
        /*
         * If something doens't need to be changed by designer, it is better to assign it through code.
         * So we don't have a risk to loose the reference.
         * There is a tag ovre the class delaration that forces the game object to have a RigidBody2D
         */
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        LookAtMouse(); // It is easier to know what's happening inside here :)
    }

    private void LookAtMouse()
    {
        Vector3 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
