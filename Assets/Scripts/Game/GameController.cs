using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int pontos;

    public void GameOver()
    {
        DontDestroyOnLoad(this.gameObject);
        pontos = ScoreController.Points;
        SceneManager.LoadScene("GameOver");
    }
}