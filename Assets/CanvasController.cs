using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField]
    Sprite[] nome = new Sprite[3];

    public void Atualizar()
    {
        for(int i = 0;i<nome.Length;i++)
        {
            nome[i] = this.transform.GetChild(0).GetComponent<Image>().sprite;
        }
    }
}
