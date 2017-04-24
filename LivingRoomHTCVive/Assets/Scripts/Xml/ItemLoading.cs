using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class ItemLoading : MonoBehaviour{

    private Valve.VR.EVRButtonId touchpad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    private ItemContaining itemCollection;
    public Text triggerL, gripL, gripR, touchL, current, change, switchs, bedroom, bathroom;
    private int counter = 0;

    // Use this for initialization
    void Start()
    {      
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        itemCollection = ItemContaining.Load(Path.Combine(Application.dataPath, "Resources/languages.xml"));

        ChangeLanguage();
    }


    private void Update()
    {
        if (controller.GetPressDown(touchpad))
        {
            ChangeLanguage();
        }  
    }

    public void ChangeLanguage()
    {
        gripL.text = itemCollection.languagess[counter].gripButtonL;
        gripR.text = itemCollection.languagess[counter].gripButtonR;
        triggerL.text = itemCollection.languagess[counter].triggerButtonL;
        current.text = itemCollection.languagess[counter].currentLanguage;
        touchL.text = itemCollection.languagess[counter].touchPadL;
        change.text = itemCollection.languagess[counter].changeLanguage;
        switchs.text = itemCollection.languagess[counter].lightSwitch;
        bathroom.text = itemCollection.languagess[counter].wallRendererSwitch;
        bedroom.text = itemCollection.languagess[counter].wallRendererSwitch;

        if (counter == itemCollection.languagess.Count -1)
        {
            counter = 0;
        }
        else
        {
            counter++;
        }

    } 
}








