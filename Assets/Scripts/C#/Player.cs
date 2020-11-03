using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    float x;
    float y;
    public Rigidbody2D pRb;
    public float moveSpeed = 0;
    public float firstSpeed = 3.0f;
    public float addSpeed = 1.5f;
    public float maxSpeed;
    Vector2 direction;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pRb = GetComponent<Rigidbody2D>();

        direction = new Vector2(x, y);
    }

    void Start()
    {
          
            
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        Debug.Log(x);
        if (x != 0)
        {
            transform.Translate(x*moveSpeed * Time.deltaTime, 0, 0);
            if (moveSpeed < firstSpeed)
            {
                moveSpeed = moveSpeed + addSpeed * Time.deltaTime;
                if (moveSpeed == firstSpeed)
                {
                    moveSpeed = firstSpeed;
                }
            }
        }
        if(x == 0)
        {
            moveSpeed -= addSpeed;
            transform.Translate(x * moveSpeed * Time.deltaTime, 0, 0);
            if (moveSpeed <= 0)
            {
                moveSpeed = 0;
            }
        }
         
        
    

    }
}
