using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody playerRb;
    [Space]
    [Header("Variables")]
    public float forwardSpeed;
    public float force;

    [Header("Mobile Controls")]
    public bool moveLeft = false;
    public bool moveRight = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); //Get the Rigidbody to the player
    }

    private void FixedUpdate()
    {
        //Add force on player to move forward
        playerRb.AddForce(0f, 0f, forwardSpeed * Time.deltaTime);

    }
    private void Update()
    {

        //Get Input by user 
        if (Input.GetKey(KeyCode.D))
        {
            //Add left force to player
            transform.position -= new Vector3(force * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Add Right force to the player
            transform.position += new Vector3(force * Time.deltaTime, 0, 0);
        }

        //Check the player y position, if y position is lessthan equalto the -4 then the game become over.
        if (transform.position.y <= -4)
        {
            GameManager.FindObjectOfType<GameManager>().GameOver(); //Active the gameOver Screen
        }

        //Mobile Input control

        if (moveLeft == true) 
        {
            transform.position += new Vector3(force * Time.deltaTime, 0, 0);
        }
        if (moveRight == true)
        {
            transform.position -= new Vector3(force * Time.deltaTime, 0, 0);
        }

    }

    public void LeftTrigger(bool canLeft)
    {
        moveLeft = canLeft;
    }
    public void RightTrigger(bool canRight)
    {
        moveRight = canRight;
    }

}
