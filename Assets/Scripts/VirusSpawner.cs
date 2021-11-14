using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject p1,p2;
    [SerializeField]
    GameObject virus;
    [SerializeField]
    float maxTime,minTime,decrease;
    float time;

    void Start()
    {
        time = maxTime;
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(virus,new Vector3(Random.Range(p1.transform.position.x,p2.transform.position.x),p1.transform.position.y),Quaternion.identity);
            if(time>minTime)
            {
                time = maxTime-decrease;
            }
        }
    }
}
