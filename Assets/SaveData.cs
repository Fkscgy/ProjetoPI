using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveData
{
    private List<Rank> ranks;

    public SaveData(List<Rank> ranks)
    {
        this.Ranks = ranks;
    }

    public List<Rank> Ranks { get => ranks; set => ranks = value; }
}
public class Rank
{
    Sprite[] name;
    long points;

    public Rank(Sprite[] name, long points)
    {
        this.Name = name;
        this.Points = points;
    }

    public Sprite[] Name { get => name; set => name = value; }
    public long Points { get => points; set => points = value; }
}