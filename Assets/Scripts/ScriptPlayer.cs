using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    private int moveSpeed = 6;
    private int jumpPower = 4;
    private bool isRightPressed = false;
    private bool isLeftPressed = false;
    private bool isUpPressed = false;
    Rigidbody2D rigidPlayer;

    void Start()
    {
        rigidPlayer = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        isRightPressed = Input.GetKey(KeyCode.RightArrow);
        isLeftPressed = Input.GetKey(KeyCode.LeftArrow);
        isUpPressed = Input.GetKey(KeyCode.UpArrow);
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        if (isRightPressed)
        {
            pos.x += moveSpeed * Time.deltaTime;
            transform.position = pos;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (isLeftPressed)
        {
            pos.x -= moveSpeed * Time.deltaTime;
            transform.position = pos;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (isUpPressed)
        {
            rigidPlayer.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
        }
    }
}
