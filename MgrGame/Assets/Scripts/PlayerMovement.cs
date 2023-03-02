using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float movementSpeed;
    public float jumpForce;

    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        MyInput();
    }

    private void FixedUpdate()
    {

        MovePlayer();
    }

    void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void MovePlayer()
    {

        moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);
        //moveDirection = player.forward * verticalInput + player.right * horizontalInput;

        //rigidbody.AddForce(moveDirection.normalized *movementSpeed *10f, ForceMode.Force);
    }

    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0, 100*jumpForce, 0));
        }

    }
}
