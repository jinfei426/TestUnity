﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public GameObject go;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Act()
    {
        go.SetActive(true);
    }

    public void shut()
    {
        go.SetActive(false);
    }
}
