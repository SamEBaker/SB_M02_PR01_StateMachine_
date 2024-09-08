using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnerboneState : IPlayerState
{
    //rotate.z.-180


    public void Enter(Player player)
    {

        player.transform.Rotate(0 , 0 , -180);
        player.currentState = this;

    }

    public void Handle(Player player)
    {
        if (Input.GetKey(KeyCode.H))
        {
            // player.transform.position = new Vector3(0.5f, -0.5f, 0);
            
            player.transform.Rotate(0, 0, 0);
            PlayerController standingState = new PlayerController();
            standingState.Enter(player);
        }
    }
}
