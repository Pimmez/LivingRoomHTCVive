using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class ItemLoading : MonoBehaviour
{

    private Valve.VR.EVRButtonId touchpad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    private ItemContaining itemCollection;
    public Text triggerL, gripL, gripR, touchL, current, change, switchs, bedroom, bathroom;
    private int counter = 0;
    private bool languageChinese = true;

    // Use this for initialization
    void Start()
    {      
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        itemCollection = ItemContaining.Load(Path.Combine(Application.dataPath, "Resources/languages.xml"));

        //InvokeRepeating("TimerTime", 2, 3);    
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



    /*
    public void ButtonTEST()
    {
        languageChinese = !languageChinese;
    }
    */


    /*
    void TimerTime()
    {
        Debug.Log("TimerTime");

        if (counter < itemCollection.AllDialogues[0].texten.Count)
        {
            current.text = itemCollection.AllDialogues[0].texten[counter];
            counter++;
        }
        else
        {
            CancelInvoke("TimerTime");
            textManager.DestroyXMLCanvas();
        }

    }

    public void Button()
    {
        itemCollection.AllDialogues[0].id = 2;
        //if counter is the same number as texten.Count, then destroy the given object
        if (counter == itemCollection.AllDialogues[0].texten.Count)
        {
        //Destroy(test);
        }
       


        grip.text = itemCollection.AllDialogues[0].texten[counter];
        //infoText.text = itemCollection.AllDialogues[0].texten[counter];
        counter++;
    }
    */

}








