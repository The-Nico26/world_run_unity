﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    public bool init = true;
    //Max : 120
    // Start is called before the first frame update
    void Start()
    {
        if (!init) return;

        Vector3 ori = new Vector3(Random.Range(-90, 30), -90, -90);
        if(transform.position.x > 0)
        {
            ori.x += 180;
        }
        transform.Rotate(ori);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, new Vector3(1, 0, 0), MainScript.m_speed * Time.deltaTime);
        if (transform.position.y <= -0.1f)
        {
            Destroy(this.gameObject);
        }
    }
}
