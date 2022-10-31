using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.Extras;

public class CanvasSelect : MonoBehaviour
{
    // Laser pointer I assigned to the right hand
    public SteamVR_LaserPointer laserPointer;

    // Colors for the button interactions that provides visual cues
    //public Color defaultColor;
    //public Color hoverColor;
    //public Color clickColor;

    private void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerInside(object sender, PointerEventArgs e) {
        //e.target.GetComponent<CanvasButtonT>().buttonColor(hoverColor);
        if (e.target.GetComponent<Button>())
        {
            Debug.Log("Button is being hovered over");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e) {
        if (e.target.GetComponent<Button>())
        {
            Debug.Log("Bye Button");
        }
    }
    
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<Button>())
        {
            Debug.Log("Button Clicked");
        }

    }
}