using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpScarePlayerState : IPlayerState
{
    private Transform mPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering State: JumpScare");
        mPlayer = player.GetComponent<Transform>();
        mPlayer.transform.position = new Vector3(0, 0.5f, -9);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            mPlayer.transform.position = new Vector3(0, 0.5f, 0);
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}
