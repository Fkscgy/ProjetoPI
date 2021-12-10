using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoreLinq;
using System.Linq;
public class RecordController : MonoBehaviour
{
    // public static List<Rank> ranks;
    private static SaveData saveData;
    private static List<Rank> ranks;

    void Awake()
    {
        LoadData();
        if(saveData?.Ranks != null)
            ranks = saveData.Ranks;
        else
            ranks = new List<Rank>();
    }
    public static void SaveGame()
    {
        if(saveData?.Ranks == null)
        {
            saveData = new SaveData(ranks);
        } else
        {
            saveData.Ranks.AddRange(ranks);
        }
        Debug.Log(saveData.Ranks[0].Name[0].name);
        saveData.Ranks = saveData.Ranks.DistinctBy(r=> new {r.NameString,r.Points}).ToList();
        string data = JsonUtility.ToJson(saveData);
        Debug.Log(data);
        PlayerPrefs.SetString("GameData",data);
    }
    public static void LoadData()
    {
        try
        {
            string data = PlayerPrefs.GetString("GameData");
            saveData = JsonUtility.FromJson<SaveData>(data);
            saveData.Ranks = saveData.Ranks.DistinctBy(r=> new {r.NameString,r.Points}).ToList();
        } catch(NullReferenceException)
        {
            saveData = null;
        }
    }
    public static List<Rank> Get()
    {
        return saveData?.Ranks;
    }
    public static void Set(Rank r)
    {
        if(r != null)
        ranks.Add(r);
    }
    
}
