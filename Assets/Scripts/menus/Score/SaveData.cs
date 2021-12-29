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