using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour {

    [SerializeField] private Light[] lights;
    private bool isClicked;

    // Update is called once per frame
    void Update ()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("We Are in the trigger");

        if (other.gameObject.tag == "Player" && isClicked)
        {
            Debug.Log("jajaja IF statement");
            foreach (Light light in lights)
            {
                Debug.Log("OOOOH LIGHTJES");
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
