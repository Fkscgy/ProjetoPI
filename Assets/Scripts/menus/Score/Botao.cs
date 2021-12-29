using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao : MonoBehaviour
{
    [SerializeField]
    CanvasController canvas;
    [SerializeField]
    Button botao;

    public void Apertar()
    {
        botao.transform.GetChild(0).GetComponent<Image>().sprite = this.transform.GetChild(0).GetComponent<Image>().sprite;
        this.transform.parent.parent.parent.gameObject.SetActive(false);
        canvas.Atualizar();
    } 
}
