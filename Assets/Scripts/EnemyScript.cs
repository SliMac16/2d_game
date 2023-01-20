using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameManager gameManager;

    private float end_WindowsPos = -14.5f;
    [SerializeField] float enemy_Speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * enemy_Speed * Time.deltaTime);

        if (transform.position.x <= end_WindowsPos)
        {
            Destroy(gameObject);
        }
    }



}
