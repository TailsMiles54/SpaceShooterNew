using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float moveSpeed = 3;

    [HideInInspector]public Vector2 targetPos;

    private float PCspeed = 0.2f;
    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");        //для теста на ПК
        float verticalInput = Input.GetAxis("Vertical");        //для теста на ПК
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * PCspeed);     //для теста на ПК
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            targetPos = Camera.main.ScreenToWorldPoint(touch.position);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}

//движение игрока