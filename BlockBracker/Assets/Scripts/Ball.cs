using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//testing

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;

    Vector2 paddleToBallVactor;
    bool hasStarted = false;


    // Start is called before the first frame update
    void Start()
    {

        paddleToBallVactor = transform.position - paddle1.transform.position; //refering to the game object


    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {      //Input.GetMouseButtonDown(0) zero represents the left mouse button
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);  //refering to the ball and telling it to have a velocity of (2f, 15f) amount   
            hasStarted = true; //the mouse has been pressed  - no need to lock the ball to the paddle anymore
        }
    }
    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVactor;
    }
}
