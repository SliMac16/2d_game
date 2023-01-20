using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] GameObject[] spawnPoints;

    GameObject current_SpawnPoint;

    private bool isGameActive;
    private int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    private PlayerHealth playerHealth;

    [SerializeField]float spawnTime = 10.0f;

    private void Awake()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnTime);
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            int enemyIndex = Random.Range(0, enemies.Length);
            current_SpawnPoint = spawnPoints[spawnIndex];
            Instantiate(enemies[enemyIndex], current_SpawnPoint.transform.position, enemies[enemyIndex].transform.rotation);
        }
        
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        if(playerHealth.CheckHealth() <= 0)
        {
            isGameActive = false;
        }
    }

    
}
