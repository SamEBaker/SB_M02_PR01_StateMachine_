using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatState : IPlayerState
{
    Rigidbody rb;

    public void Enter(Player player)
    {
        player.transform.Rotate(0, 0, 0);
        rb = player.GetComponent<Rigidbody>();
        rb.transform.localScale = new Vector3(5f, 0.3f, 1);
        player.currentState = this;
    }

    public void Handle(Player player)
    {
        if (!Input.GetKey(KeyCode.S))
        {
            rb.transform.localScale = new Vector3(1, 1, 1);
            PlayerController standingState = new PlayerController();
            standingState.Enter(player);
        }
    }
}
