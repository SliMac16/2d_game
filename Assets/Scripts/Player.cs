using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5;

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
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float moveUnit = speed * Time.fixedDeltaTime;

        Vector2 move = Vector2.zero;

        if (moveUp)
        {
            move.y += moveUnit;
        }

        if (moveDown)
        {
            move.y -= moveUnit;
        }
        pos += move;
        transform.position = pos;
    }
}
