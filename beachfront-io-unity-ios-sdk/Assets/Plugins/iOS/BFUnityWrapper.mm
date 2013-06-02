//
//  BFUnityWrapper.mm
//
//  Created by Sumeru Chatterjee on 4/29/12.
//  Copyright (c) 2013 Beachfront Media LLC. All rights reserved.
//

#import "BFUnityWrapper.h"
#import <BFIOSDK/BFIOSDK.h>

///////////////////////////////////////////////////////////////////////////////////////////////////
NSString* NSStringFromCString (const char* string) {
    if (string)
        return [NSString stringWithUTF8String:string];
    else
        return [NSString stringWithUTF8String: ""];
}

///////////////////////////////////////////////////////////////////////////////////////////////////
void bfio_showAd(const char* appID,const char* adUnitID){
    
    //Call the SDK to show the ad
    [BFIOSDK showAdWithAppID:NSStringFromCString(appID) adUnitID:NSStringFromCString(adUnitID)];
}