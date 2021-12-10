using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutSceneController : MonoBehaviour
{
    [SerializeField]
    Image imagem;
    [SerializeField]
    Sprite imagemm;
    int index = 0;

    public void Prosseguir()
    {
        if(index>0)
        SceneManager.LoadScene("Game");
        imagem.sprite = imagemm;
        index++;

    }
}
