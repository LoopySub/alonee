using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public PlayerMovement player;
    public class PlayerData
    {
       public string name;
      
    }
    public static DataManager instance;
    public PoolManager pool;
    public float gameTime;
    public float maxGameTime = 2 * 60f;
    public int CurrentIndex;
    //public PlayerData playerData = new PlayerData();
    string path;

    public PlayerData playerData;
    public Text playerName;
 
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }


    private void Update()
    {
       gameTime += Time.deltaTime;
        if (gameTime > maxGameTime)
        {
            //TODO
        }
    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(playerData, true);
        path = Path.Combine(Application.dataPath, playerData.name + "JSon");
        File.WriteAllText(path, data);
    }
    public void LoadData()
    {
        string data = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(data);
    }

    public void LoadSceneMainScene()
    {
        playerData.name = playerName.text;
        SceneManager.LoadScene("MainScene");
        Debug.Log(playerName.text);

    }
}
