using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] TextMeshProUGUI timerText;
    private PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0.00");

        if(currentTime <= 0 || playerHealth.CheckHealth() <=0)
        {
            currentTime = 0;
        }
    }
}
