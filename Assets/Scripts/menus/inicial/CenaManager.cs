using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenaManager : MonoBehaviour
{
    public void AlterarCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}

