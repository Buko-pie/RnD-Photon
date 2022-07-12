using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class NetworkPlayer : NetworkBehaviour, IPlayerLeft
{
    public static NetworkPlayer Local {get; set;}
    void Start()
    {

    }

    public override void Spawned()
    {
        if(Object.HasInputAuthority)
        {
            Local = this;

            Debug.Log("Spawned Local Player");
        }
        else
        {
            Debug.Log("Spawned remote player");
        }
    }

    public void PlayerLeft(PlayerRef player)
    {
        if(player == Object.InputAuthority)
        {
            Runner.Despawn(Object);
        }
    }
}
