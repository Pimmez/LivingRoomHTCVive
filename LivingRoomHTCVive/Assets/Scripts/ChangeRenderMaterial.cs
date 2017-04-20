﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRenderMaterial : MonoBehaviour{

    public Material[] materials;
    public float changeInterval = 0.33F;
    public Renderer[] rends;

    private int counter;

    void Start()
    {
        //rend = GetComponent<Renderer>();
        //rend.enabled = true;
        counter = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(counter < materials.Length -1)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }

            foreach (Renderer rend in rends)
            {
                rend.sharedMaterial = materials[counter];
            }
        }
    }
}
