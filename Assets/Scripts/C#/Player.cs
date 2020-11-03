using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    //float x;
    //float y;
    public Rigidbody2D pRb;
    public float moveSpeed = 0;
    public float firstSpeed = 3.0f;
    public float addSpeed = 1.5f;
    public float maxSpeed;
    public bool stopMove = false;
    Vector2 direction;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pRb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
          
            
    }

    void Update()
    {
        //x = Input.GetAxis("Horizontal");
        //y = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            stopMove = false;
            if (moveSpeed < firstSpeed)
            {
                moveSpeed += addSpeed * Time.deltaTime;
                transform.Translate(-moveSpeed, 0, 0);
                if (moveSpeed == firstSpeed)
                {
                    moveSpeed = firstSpeed;
                }
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            stopMove = false;
            if (moveSpeed < firstSpeed)
            {
                moveSpeed += addSpeed * Time.deltaTime;
                transform.Translate(moveSpeed, 0, 0);
                if (moveSpeed == firstSpeed)
                {
                    moveSpeed = firstSpeed;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            stopMove = true;
        }

        if(stopMove == true)
        {
            while (moveSpeed != 0)
            {
                moveSpeed -= addSpeed*Time.deltaTime;
                transform.Translate(moveSpeed, 0, 0);
                if (moveSpeed <= 0)
                {
                    moveSpeed = 0;
                    break;
                }
            }


        }

    }
}
