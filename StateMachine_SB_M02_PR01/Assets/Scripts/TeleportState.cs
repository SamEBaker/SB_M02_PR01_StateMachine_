using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportState : IPlayerState
{
    public void Enter(Player player)
    {
        player.transform.position = player.teleportPos[Random.Range(0, 5)].transform.position;
        player.currentState = this;
    }

    public void Handle(Player player)
    {
        if (!Input.GetKey(KeyCode.G))
        {

            PlayerController standingState = new PlayerController();
            standingState.Enter(player);
        }
    }
}
