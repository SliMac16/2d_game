using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] GameObject[] spawnPoints;

    GameObject current_SpawnPoint;

    private bool isGameActive = true;

    [SerializeField]float spawnTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            int enemyIndex = Random.Range(0, enemies.Length);
            current_SpawnPoint = spawnPoints[spawnIndex];
            Instantiate(enemies[enemyIndex], current_SpawnPoint.transform.position, enemies[enemyIndex].transform.rotation);
        }
        
    }
}
