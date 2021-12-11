using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBehaviour : MonoBehaviour
{
    void Awake()
    {
            RecordController.LoadData();
            List<Rank> ranks = RecordController.Get(); 
            if(ranks == null)
                return;
            if(ranks.Count>10)
                ranks.RemoveRange(10,ranks.Count-10);
            ranks.Sort((x,y)=>y.Points.CompareTo(x.Points));
            for (int i = 0; i < ranks.Count; i++)
            {
                Transform c = this.transform.GetChild(i);
                c.gameObject.SetActive(true);
                for (int o = 0; o < c.childCount; o++)
                {
                    if(o<3)
                    {
                        Image a = c.GetChild(o).GetComponent<Image>();
                        a.sprite = ranks[i].Name[o];
                    } else if(o>=3)
                    {
                        TextMeshProUGUI b = c.GetChild(o).GetComponent<TextMeshProUGUI>();
                        b.text = $": {ranks[i].Points}";
                    }
                }
            }
    }
}
