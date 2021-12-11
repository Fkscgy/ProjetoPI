using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    private bool apertou = false;
    [SerializeField]
    Sprite[] nome = new Sprite[3];
    
    void Awake()
    {
        Atualizar();
    }
    public void Atualizar()
    {
        for(int i = 0;i<nome.Length;i++)
        {
            nome[i] = this.transform.GetChild(0).GetChild(i+1).GetChild(0).GetComponent<Image>().sprite;
        }
    }
    public void Confirmar()
    {
        if(apertou)
            return;
        Rank r = new Rank(nome,ScoreController.Points);
        RecordController.Set(r);
        RecordController.SaveGame();
        apertou = true;
    }
}
