using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] players;
    private GameObject curPlayer;
    void Start()
    {
        curPlayer = Instantiate(players[0]);
    }

    
    public void ChangePlayer(int PlayerIndex)
    {
        Destroy(curPlayer);
        curPlayer = Instantiate(players[PlayerIndex]);
    }
}
