using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{

    //overrides / callbacks and that bruv
    public override void OnStartServer()
    {
        Debug.Log("server start");
        base.OnStartServer();
    }

    public override void OnStopServer()
    {
        Debug.Log("SERVER: server stopped");
        base.OnStopServer();
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("CLIENT: connected to server bruv");
        base.OnClientConnect(conn);
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("CLIENT: disconnected from server bruv");
        base.OnClientDisconnect(conn);
    }




}
