using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class BFIOSDK
{
    // import the bfio_showAd method
    [DllImport ("__Internal")]
    private static extern void bfio_showAd(string appID,string adUnitID);

    // wrap imported C-function to C# method
    public static void BFIO_ShowAd(String appId,String adUnitID)
	{
		bfio_showAd(appId,adUnitID);
	}
}