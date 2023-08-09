using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private float playerSpeed;
    private float groundHeight;
    private float jumpSpeed;
    private bool isJumping;
    private float currentHealth, maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 4f;
        goundHeight = 0.51f;
        jumpSpeed = 15f;
        isJumping = false;

        playerTransform.position = new Vector3(0f, goundHeight, -10f);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movementVector = Vector3.zero;
        float xMovement = 0;
        float zMovement = 0;

        if(Input.GetKey(KeyCode.W))
        {
            zMovement = playerSpeed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            zMovement = -playerSpeed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            xMovement = -playerSpeed;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            xMovement = -playerSpeed;
        }


    }
}
