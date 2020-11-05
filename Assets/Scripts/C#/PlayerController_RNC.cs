using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_RNC : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    public float playerRot = 2.0f;
    public GameObject Body;
    public GameObject[] points;

    int currentPoint;

    static Vector2 currentPointPosition;


    void CheckPoint()
    {
        if(currentPoint < points.Length)
        {

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Body.()
        //}
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Body.transform.forward * playerSpeed * Time.deltaTime);
        }
        
    }
}
