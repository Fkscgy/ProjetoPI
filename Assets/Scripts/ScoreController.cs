using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    Text texto;
    static int points;

    public static int Points { get => points;private set => points = value; }

    void Start()
    {
        Points = 0;
    }
    public void Increase(int amount)
    {
        Points += amount;
        ChangeScore();
    }
    void ChangeScore()
    {
        texto.text = $"Score: {points}";
    }
}
