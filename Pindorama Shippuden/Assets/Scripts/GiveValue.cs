using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GiveValue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score; 

    public void Start()
    {
        string newScore = StaticData.valueToKeep;
        score.text = newScore;
    }
}
