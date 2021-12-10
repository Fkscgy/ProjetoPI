using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordController : MonoBehaviour
{
    public static List<Rank> ranks;
    public static SaveData saveData;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        LoadData();
        GetState();
    }
    private void SaveGame()
    {
        var data = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString("GameData",data);
    }
    public void LoadData()
    {
        var data = PlayerPrefs.GetString("GameData");
        saveData = JsonUtility.FromJson<SaveData>(data);
    }
    public static void SetState()
    {
        if(saveData.Ranks == null)
            saveData.Ranks = new List<Rank>();
        
        // ranks.Sort((x,y)=>x.Points.CompareTo(y.Points));
        saveData.Ranks = ranks;
    }
    public static void GetState()
    {
        ranks = saveData.Ranks;
    }
}
