using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScore;
    [SerializeField] TextMeshProUGUI lastScore;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("LastScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("LastScore"));
        }
        lastScore.text = PlayerPrefs.GetInt("LastScore").ToString();
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString(); 
    }

    
}
