﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public ColorManager cm;

	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.color = cm.color;
	}
}
