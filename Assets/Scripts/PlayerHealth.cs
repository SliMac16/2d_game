using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textHealth;
    [SerializeField] private int startHealth = 3;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
        UpdateHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("touchingEnemy");
            Destroy(other.gameObject);
            currentHealth--;
            UpdateHealth(currentHealth);
            if(currentHealth <= 0)
            {
                Destroy(gameObject);
                FindObjectOfType<GameManager>().GetComponent<GameManager>().GameOver();
            }
        }
    }

    void UpdateHealth(int currentHealth)
    {
        textHealth.text = currentHealth.ToString("0");
    }

    public int CheckHealth()
    {
        return currentHealth;
    }

    
}
