using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  

public class GetValue : MonoBehaviour
{
    public TextMeshProUGUI score;  

    public void LoadSceneAndKeepValue()
    {
        string dataToKeep = score.text; 
        StaticData.valueToKeep = dataToKeep;
        SceneManager.LoadScene("FryingStep");
    }
}
