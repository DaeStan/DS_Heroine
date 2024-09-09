using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entering State: Standing");
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transition to jump
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // transition to duck
            DuckingPlayerState duckingState = new DuckingPlayerState();
            duckingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // transition to hide
            HidePlayerState hideingState = new HidePlayerState();
            hideingState.Enter(player);
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            // transition to jump scare
            JumpScarePlayerState jumpScarePlayerState = new JumpScarePlayerState();
            jumpScarePlayerState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            // transition to build
            BuildPlayerState buildingState = new BuildPlayerState();
            buildingState.Enter(player);
        }
    }
}
