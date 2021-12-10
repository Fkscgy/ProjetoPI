using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[System.Serializable]
public class SaveData
{
    public SaveData(List<Rank> ranks)
    {
        this.Ranks = ranks;
    }

    [SerializeField]
    private List<Rank> ranks;

    public List<Rank> Ranks { get => ranks; set => ranks = value; }
}
[System.Serializable]
public class Rank
{
    public Rank(Sprite[] name, long points)
    {
        this.Name = name;
        this.Points = points;
        foreach (Sprite n in name)
        {
            NameString += n.name;
        }
    }

    [SerializeField]
    private string nameString;
    [SerializeField]
    private Sprite[] name;
    [SerializeField]
    private long points;

    public Sprite[] Name { get => name; set => name = value; }
    public long Points { get => points; set => points = value; }
    public string NameString { get => nameString; set => nameString = value; }
}