using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyDestruction : MonoBehaviour
{
    public int points = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().GetComponent<GameManager>().UpdateScore(points);
        }
    }
}
