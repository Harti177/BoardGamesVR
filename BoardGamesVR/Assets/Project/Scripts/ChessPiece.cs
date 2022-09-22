using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun; 

public class ChessPiece : MonoBehaviour
{
    PhotonView pv;

    private void Start()
    {
        pv = GetComponent<PhotonView>();     
    }

    public void OnObjectGrabbed()
    {
        pv.TransferOwnership(PhotonNetwork.LocalPlayer);
    }
}
