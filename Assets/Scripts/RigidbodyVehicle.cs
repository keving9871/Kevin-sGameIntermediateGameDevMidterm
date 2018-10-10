using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyVehicle : MonoBehaviour
{

    Rigidbody rbody;
    Vector2 inputVector; // x is horizontal, y is vertical input
    public float turnSpeed;
    public float moveSpeed;
    public int count;
    public bool stalled;
    public float timer;
    public Progressbar progressbarscript;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        count = 0;
        stalled = true;
        timer = Random.Range(15f, 32f);
        // Cursor.visible = false;
    }



    // Update is called once per frame
    void Update()
    {
        // input handling
        // Input.GetAxis() returns a float between -1f and 1f, and 0 if nothing is happening
        // horizontal = A/D, Left/Right... Left = -1f, Right = +1f
        // put input values into the inputVector, for FixedUpdate
        if (!stalled)
        {
            float horizontal = Input.GetAxis("Horizontal");
            // vertical = W/S, Up/Down... Up = +1, Down = -1f
            float vertical = Input.GetAxis("Vertical");
            inputVector = new Vector2(horizontal, vertical);
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                stalled = true;
                timer = Random.Range(15f, 32f);
                progressbarscript.progress = 0f;
            }
        }
       
    }

    // FixedUpdate runs every physics frame
    // to change physics framerate, go to Edit > Project Settings > Time
    void FixedUpdate()
    {
        // forward / backward thrust
        //  if (Input.GetKeyDown(KeyCode.G))
        if (!stalled)
        {
            if (rbody.velocity.magnitude < 25f) // how fast are we going? if too fast, don't speed up
            {
                rbody.AddForce(transform.forward * inputVector.y * moveSpeed, ForceMode.Impulse);
            }

            // left/right turning... torque is rotational force
            rbody.AddTorque(0f, inputVector.x * turnSpeed, 0f);
        }

    }
}