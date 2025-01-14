﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.MoveSpeed = 0.1f;
    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.DownArrow))
            moveDown();
        if (Input.GetKey(KeyCode.UpArrow))
            moveUp();
        if (Input.GetKey(KeyCode.LeftArrow))
            moveLeft();
        if (Input.GetKey(KeyCode.RightArrow))
            moveRight();
        if (MobileMovementManager.Instance.down)
            moveDown();
        if (MobileMovementManager.Instance.up)
            moveUp();
        if (MobileMovementManager.Instance.left)
            moveLeft();
        if (MobileMovementManager.Instance.right)
            moveRight();
    }


    void Update()
    {
        if (GameManager.Instance.PowerTime >= 0)
        {
            GameManager.Instance.MoveSpeed = 0.2f;
            GameManager.Instance.PowerTime -= Time.deltaTime;
        }
        else
            GameManager.Instance.MoveSpeed = 0.1f;
    }

    public void moveUp()
    {

        if (transform.position.y < 1.076795f)
            gameObject.transform.Translate(0, GameManager.Instance.MoveSpeed, 0);

    }
    public void moveDown()
    {

        if (transform.position.x > 1.482f && transform.position.y < -1.15f) { }
        else
        {
            if (transform.position.y >= -5.4f)
                gameObject.transform.Translate(0, -GameManager.Instance.MoveSpeed, 0);
        }

    }
    public void moveLeft()
    {

        if (transform.position.x > -7.8178f)
            gameObject.transform.Translate(-GameManager.Instance.MoveSpeed, 0, 0);

    }

    public void moveRight()
    {

        if (transform.position.x > 0.582197f && transform.position.y < -3.0f && transform.position.x < 2.2f)
        {
        }
        else
        {
            if (transform.position.x < 6.382194f)
            {
                gameObject.transform.Translate(GameManager.Instance.MoveSpeed, 0, 0);
            }
        }

    }

}

