﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatOb : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0, Space.World); 
    }
}
