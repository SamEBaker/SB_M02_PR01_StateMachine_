using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NoirState : IPlayerState
{
    //set mustach and hat active
    //make black and white post processing
    public PostProcessVolume volume;


    public void Enter(Player player)
    {
        player.colorGrading.saturation.value = -100f;
        player.hat.SetActive(true);
        player.stash.SetActive(true);

        player.currentState = this;
    }

    public void Handle(Player player)
    {
        if (!Input.GetKey(KeyCode.F))
        {
            //set inactive
            player.hat.SetActive(false);
            player.stash.SetActive(false);
            player.colorGrading.saturation.value = 0f;

            PlayerController standingState = new PlayerController();
            standingState.Enter(player);
        }
    }
}
