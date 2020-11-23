﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval = Time.time;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > timeInterval + 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeInterval = Time.time;
        }
    }
}
