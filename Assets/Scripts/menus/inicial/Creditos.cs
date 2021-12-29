using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditos : MonoBehaviour
{
    static bool inicio = true;
    [SerializeField]
    GameObject menu;

    [SerializeField]
    GameObject creditos;
    // Start is called before the first frame update
    void Awake()
    {
        if(inicio)
        StartCoroutine(Count());
    }
    IEnumerator Count()
    {
        menu.SetActive(false);
        creditos.SetActive(true);
        yield return new WaitForSeconds(5f);
        menu.SetActive(true);
        creditos.SetActive(false);
        inicio = false;
    }
}
