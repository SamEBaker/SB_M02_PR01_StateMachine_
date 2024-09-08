using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingState : IPlayerState
{
    Rigidbody rb;

    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        rb.transform.localScale = new Vector3(2f, 0.5f, 1);
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
