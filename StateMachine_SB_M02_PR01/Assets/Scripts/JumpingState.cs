using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IPlayerState
{
    Rigidbody rb;
    float launch;

    public void Enter(Player player)
    { 
        rb = player.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 10, 0);
        launch = Time.time;
        player.currentState = this;
    }

    public void Handle(Player player)
    {
        if (Physics.Raycast(rb.transform.position, Vector3.down, 1f) && (Time.time - launch > 0.5f))
        {
            PlayerController standingState = new PlayerController();
            standingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DivingState divingState = new DivingState();
            divingState.Enter(player);
        }
    }

}
