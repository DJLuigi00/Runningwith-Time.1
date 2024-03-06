using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    private float moveSpeed = 5f;
    private float horizontalImput;
    private float verticalImput;
    private float jumpSpeed = 150f;
    private float gravity = -1f;


    void MovePlayer()
    {
        // set player input values
        horizontalImput = Input.GetAxis("Horizontal");
        verticalImput = Input.GetAxis("Vertical");


        if (characterController.isGrounded)
        {
            gravity = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravity += jumpSpeed;
        }

        

        if (!characterController.isGrounded)
        {
            gravity += Physics.gravity.y; 
        }


        characterController.Move(new Vector3(horizontalImput, gravity, verticalImput) * moveSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
}
