using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    private int dirY;
    private int dirX;

    private float speed = 0.06f;

    public bool moveTop = false;
    public bool moveBottom = false;
    public bool moveRight = false;
    public bool moveLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            if (moveRight)
            {
                dirX = 1;
                dirY = 0;
            }
        }
        else if (Input.GetKey(KeyCode.A) )
        {
            if (moveLeft)
            {
                dirX = -1;
                dirY = 0;
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (moveTop)
            {
                dirY = 1;
                dirX = 0;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (moveBottom)
            {
                dirY = -1;
                dirX = 0;
            }
        }
        else
        {
            dirY = 0;
            dirX = 0;
        }
        
    }

    public void AccessMovementToAllDirections()
    {
        moveRight = true;
        moveLeft = true;
        moveTop = true;
        moveBottom = true;
    }


    public void StopMovingByDirection(Vector3 delta)
    {
        if(delta.y == 1)
        {
            //from top
            moveTop = false;
        }else if (delta.y == -1)
        {
            moveBottom = false;
        }

        if (delta.x == 1)
        {
            moveLeft = false;
        }
        else if (delta.x == -1)
        {
            moveRight = false;
        }

        if(delta.x == 0)
        {
            moveRight = true;
            moveLeft = true;
        }
        if (delta.y == 0)
        {
            moveTop = true;
            moveBottom = true;
        }
    }

    private void FixedUpdate()
    {
        transform.localPosition += new Vector3(dirX * speed, dirY * speed, 0);
    }

}
