using UnityEngine;
using System;
using System.Collections;

public class BFIOSDKDemo : MonoBehaviour
{   
    private GUIStyle labelStyle = new GUIStyle();
    private float centerX = Screen.width / 2;

    // Use this for initialization
    void Start ()
    {   
        labelStyle.fontSize = 24;
        labelStyle.normal.textColor = Color.black;
        labelStyle.alignment = TextAnchor.MiddleCenter;
    }

    void OnGUI ()
    {
        GUI.Label(new Rect(centerX - 200, 20, 400, 35), "BFIOSDK Demo", labelStyle);
        if (GUI.Button(new Rect(centerX - 75, 80, 150, 35), "Show Ad"))
        {
			String appID = "b780ee34-2d18-4913-8582-e762486b86d3";
			String adUnitID = "4924822d-0324-47e1-eb44-de8d683cf517";
            BFIOSDK.BFIO_ShowAd(appID,adUnitID);
        }
    }

}