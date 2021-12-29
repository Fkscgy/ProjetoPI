using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField]
    char[] nome = new char[3];
    
    void Awake()
    {
        Atualizar();
    }
    public void Atualizar()
    {
        for(int i = 0;i<nome.Length;i++)
        {
            nome[i] = this.transform.GetChild(0).GetChild(i+1).GetChild(0).GetComponent<Image>().sprite.name[0];
        }
    }
    public void Confirmar()
    {
        Rank r = new Rank(nome,ScoreController.Points);
        RecordController.Set(r);
        RecordController.SaveGame();
        SceneManager.LoadScene("Menu");
    }
}
