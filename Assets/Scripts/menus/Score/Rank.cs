using System;
using UnityEngine;

[System.Serializable]
public class Rank
{
    public Rank(char[] name, long points)
    {
        this.Name = name;
        this.Points = points;
        foreach (char c in Name)
        {
            NameString +=c;
        }
    }
    [SerializeField]
    private char[] name;
    [SerializeField]
    private long points;
    [SerializeField]
    private string nameString;

    public char[] Name { get => name;private set => name = value; }
    public long Points { get => points;private set => points = value; }
    public string NameString { get => nameString;private set => nameString = value; }
}