using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class LobbyManager : MonoBehaviourPunCallbacks
{
  public TMP_InputField createInput;
  public TMP_InputField joinInput;
  private void Start() {
    
  }

  public void CreateRoom(){
    Debug.Log(createInput.text);
    PhotonNetwork.CreateRoom(createInput.text);
  }

  public void JoinRoom(){
    Debug.Log(joinInput.text);
    PhotonNetwork.JoinRoom(joinInput.text);
  }

public override void OnJoinedRoom()
{
  PhotonNetwork.LoadLevel("SampleScene");
}
}
