﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    private bool obstacle_pass = false;

    void Update()
    {
        if (transform.position.x <= 0 && !obstacle_pass)
        {
            GameManager.thisManager.UpdateScore(1);
            obstacle_pass = true;
        }

        if (transform.position.x <= -8)
            Destroy(gameObject);
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
    }
}
