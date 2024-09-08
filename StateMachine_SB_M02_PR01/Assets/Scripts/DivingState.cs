using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState : IPlayerState
{
    Rigidbody rb;

    public void Enter(Player player)
    {

        rb = player.GetComponent<Rigidbody>();
        rb.AddForce(0, -10000 * Time.deltaTime, 0, ForceMode.VelocityChange);
        player.currentState = this;
    }

    public void Handle(Player player)
    {
        if (Physics.Raycast(rb.transform.position, Vector3.down, 0.55f))
        {
            IPlayerState nextState;
            if (Input.GetKey(KeyCode.S))
            {

                nextState = new SplatState();
                
            }
            else
            {
                nextState = new PlayerController();
            }
            nextState.Enter(player);
        }
    }
}
