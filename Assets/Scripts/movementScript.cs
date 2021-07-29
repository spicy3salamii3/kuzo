using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class movementScript : NetworkBehaviour
{
    
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 0.1f, moveVertical * 0.1f, 0);
            transform.position = transform.position + movement;
        }
    }

    void Update()
    {
        HandleMovement();

        //checks if client presses x and then sends hola back to the server

        if (isLocalPlayer && Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("CLIENT: sending hola (input) to server");
            hola();
        }

    }

    public override void OnStartServer()
    {
        Debug.Log("SERVER: player has spawned");
        base.OnStartServer();
    }

    //server

    [Command]
    void hola()
    {
        Debug.Log("SERVER: receieved hola (input) from client");
    }
}
