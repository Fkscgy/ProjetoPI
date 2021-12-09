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
    Sprite[] imagens;
    int index = 0;

    public void Prosseguir()
    {
        if(index < imagens.Length-1)
        {
            index++;   
        } else
        {
            SceneManager.LoadScene("Game");
        }
        imagem.sprite = imagens[index];
    }
}
