using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField]
    char[] nick = new char[3];

    public void Atualizar()
    {
        for(int i = 0;i<nick.Length;i++)
        {
            // Debug.Log(/*char.Parse(*/this.transform.GetChild(i).GetComponent<Image>().sprite.texture.);
            nick[i] = this.transform.GetChild(i).GetComponent<NomeBehaviour>().letra;
        }
    }
}
