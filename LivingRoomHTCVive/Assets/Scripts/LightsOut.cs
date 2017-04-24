using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour {

    [SerializeField] private Light[] lights;
    private bool isClicked;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && isClicked)
        {
            foreach (Light light in lights)
            {
                light.enabled = false;
                isClicked = false;
            }

        }
        else if (other.gameObject.tag == "Player" && !isClicked)
        {

            foreach (Light light in lights)
            {
                light.enabled = true;
                isClicked = true;
            }

        }

    }

}
