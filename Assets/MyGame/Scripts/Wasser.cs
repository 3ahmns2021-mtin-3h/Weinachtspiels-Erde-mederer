﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Wasser");
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("hallo" + collision.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
