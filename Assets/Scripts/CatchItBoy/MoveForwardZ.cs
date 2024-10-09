﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardZ : MonoBehaviour
{
    private float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
