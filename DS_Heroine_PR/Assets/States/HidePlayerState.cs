using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HidePlayerState : IPlayerState
{
    Player mPlayer;
    MeshRenderer mrPlayer;
    

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Hiding");
        mrPlayer = player.GetComponent<MeshRenderer>();
        mrPlayer.enabled = false;
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mrPlayer.enabled = true;
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}