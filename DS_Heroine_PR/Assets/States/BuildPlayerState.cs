using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlayerState : IPlayerState
{
    private Transform mPlayer;
    Player playerPyrimid;

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Build");
        mPlayer = player.GetComponent<Transform>();
        playerPyrimid = player;
        playerPyrimid.pyrimid.transform.position = new Vector3(4.65f, -1.9f, 9.65f);
        mPlayer.transform.position = new Vector3(2.3f, 0.5f, 4.5f);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            mPlayer.transform.position = new Vector3(0, 0.5f, 0);
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }
    }
}
