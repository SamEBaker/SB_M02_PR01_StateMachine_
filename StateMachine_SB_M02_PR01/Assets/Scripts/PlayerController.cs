using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : IPlayerState
{
    public void Enter(Player player)
    {
        //standing state

        player.currentState = this;
    }

    public void Handle(Player player)
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DuckingState duckingState = new DuckingState();
            duckingState.Enter(player);
        }

        
        if (Input.GetKeyDown(KeyCode.F))
        {
            NoirState noirState = new NoirState();
            noirState.Enter(player);
        }
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            TeleportState teleportState = new TeleportState();
            teleportState.Enter(player);
        }
        
        if (Input.GetKeyDown(KeyCode.H))
        {

            DinnerboneState dinnerBoneState = new DinnerboneState();
            dinnerBoneState.Enter(player);
        }
        
    }
}
