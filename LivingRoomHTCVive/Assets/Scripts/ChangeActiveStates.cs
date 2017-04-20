using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeActiveStates : MonoBehaviour {

    public SteamVR_TrackedObject leftController;
    public GameObject[] gameObjects;
    public SteamVR_LaserPointer laserpointer;
    private bool toggleBool = false;

    void Update()
    {
        SteamVR_Controller.Device leftDevice = SteamVR_Controller.Input((int)leftController.index);
        if (leftDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log("Left Grip is Pressed");
            ToggleVisibility();
        }
    }
   
    void ToggleVisibility()
    {
        Debug.Log("ToggleVisibility :: We are In the function");
        toggleBool = !toggleBool;
        laserpointer.isActive = !laserpointer.isActive;
        Debug.Log("toggleBool ColorPicker is: " + toggleBool);
        Debug.Log("laserpointer is: " + laserpointer.active);

        foreach (GameObject go in gameObjects)
        {
            //This will loop through all of the array items
            //You can refer to all the items individually with the 'go' variable
            
            go.SetActive(toggleBool);
            
        }
    }
}
