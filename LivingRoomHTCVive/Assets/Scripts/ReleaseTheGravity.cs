using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseTheGravity : MonoBehaviour
{ 
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    //public SteamVR_TrackedObject rightController;

    private bool gravity = true;
    public GameObject[] gameObjects;
    [SerializeField] private ParticleSystem particle;

    // Use this for initialization
    void Start ()
    {
        gravity = GetComponent<Rigidbody>().useGravity;
	}

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        Debug.Log("TriggerEnter");
        if (controller.GetPressDown(triggerButton) && other.gameObject.tag == "Gravity")
        {
            Debug.Log("Release?");

            ReleaseGravity();
        }
    }

    void ReleaseGravity()
    {
        Debug.Log("ReleaseGravity Funtions");
        gravity = !gravity;
        particle.Play();
        foreach (GameObject go in gameObjects)
        {
            //This will loop through all of the array items
            //You can refer to all the items individually with the 'go' variable
            Debug.Log("ReleaseGravity:" + go.GetComponent<Rigidbody>().useGravity);
            go.GetComponent<Rigidbody>().useGravity = !go.GetComponent<Rigidbody>().useGravity;
            Debug.Log("ForEach Gravity");
        }
        if(!gravity)
        {
            particle.Stop();
        }

    }
}
