﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_spin : MonoBehaviour
{
    
    public Vector3 spin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(spin);
    }
}
