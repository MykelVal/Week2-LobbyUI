using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContainer : MonoBehaviour
{
    [SerializeField] private GameObject _hostIndicator;
    [SerializeField] private Text _playerText;
    [SerializeField] private GameObject _hostBtn;

    public void UpdatePlayerInfo(Player info, int _key)
    {
        _hostBtn.SetActive(PhotonNetwork.LocalPlayer.IsMasterClient);
        if (info.IsMasterClient)
        {
            _hostIndicator.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
            _hostBtn.SetActive(false);
        }
        else { _hostIndicator.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1); }

         _playerText.text = $"#{_key} | {info.NickName} | {info.ActorNumber} | {info.UserId} ";


    }
}
