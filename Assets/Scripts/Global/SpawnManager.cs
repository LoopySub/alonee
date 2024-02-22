using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] playerobj;
    public Text nickname;
    
    
    void Start()
    {
        int playerID= DataManager.instance.CurrentIndex;
        Instantiate(playerobj[playerID]);

        nickname.text = DataManager.instance.playerData.name +"ดิ";

    }

   
}
