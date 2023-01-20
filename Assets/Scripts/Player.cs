using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    float speed = 5;

    float WindowEdge = 4.50f;

    bool moveUp;
    bool moveDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.S);

        FireBullet();
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float moveUnit = speed * Time.fixedDeltaTime;

        Vector2 move = Vector2.zero;

        if (moveUp && pos.y <= WindowEdge )
        {
            move.y += moveUnit;
        }

        if (moveDown && pos.y >= -WindowEdge)
        {
            move.y -= moveUnit;
        }
        pos += move;
        transform.position = pos;
    }

    void FireBullet()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
