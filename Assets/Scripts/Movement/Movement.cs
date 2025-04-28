using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public Transform orientation;

    [Header("Ground")]
    public float playerHeight;
    public LayerMask groundMask;
    bool grounded;

    public float groundDrag;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    public Rigidbody rb;

    public float airMultiplier;

    public float fallMultiplier;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.75f + 0.2f, groundMask);

        if (!GameManager.instance.isListOpen)
        {
            MyInput();
            SpeedControl();

            if (grounded)
                rb.drag = groundDrag;
            else
                rb.drag = 0;
        }
    }

    private void FixedUpdate()
    {
        if (!GameManager.instance.isListOpen)
        {
            MovePlayer();

            if (!grounded)
            {
                rb.AddForce(Vector3.down * fallMultiplier, ForceMode.Acceleration);
            }
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (grounded)
            rb.velocity = new Vector3(moveDirection.normalized.x * moveSpeed, rb.velocity.y, moveDirection.normalized.z * moveSpeed); // ivmesiz hareket
        else if (!grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
