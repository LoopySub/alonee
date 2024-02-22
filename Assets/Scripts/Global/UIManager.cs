using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PlayerManager _playerManager;
    int playerMaxNum;
    int playerCurrentNum;

 
    void Start()
    {
        playerMaxNum = _playerManager.players.Length;
    }

    public void SelectPlayer(bool IsLeft)
    {
        if (IsLeft)
        {
            if (playerCurrentNum > 0)
            {
                playerCurrentNum--;
                _playerManager.ChangePlayer(playerCurrentNum);
            }
        }
            
        else
        {
            if(playerCurrentNum < playerMaxNum -1)
            {
                playerCurrentNum++;
                _playerManager.ChangePlayer(playerCurrentNum);
            }
        }
        DataManager.instance.CurrentIndex = playerCurrentNum;



    }

}
