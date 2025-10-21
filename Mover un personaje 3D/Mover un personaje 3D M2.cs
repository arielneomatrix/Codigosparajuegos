using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class MoverunpersonajeedM2 : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;
    Vector3 movementInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Vector3 movementInput = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movementInput.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementInput.z = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movementInput.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movementInput.x = -1;

        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementInput.z = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movementInput.z = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementInput.x = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementInput.x = -1;

        }
    }

    protected void FixedUpdate()

    {
        Move(movementInput);
    }


    void Move(Vector3 direction)

    {
        rb.AddForce(direction.normalized * speed, ForceMode.Acceleration);
        //rb.MovePosition (rb.position + direction.normalized * speed * Time.fixedDeltaTime);

    }

}

void Move(Vector3 direction)

    {
        controller.SimpleMove(direction.normalized * speed);


    }

}