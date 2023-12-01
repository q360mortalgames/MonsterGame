//using System;
//using UnityEngine;
//using GoogleMobileAds.Api;

//public class InterstitialAdManager : MonoBehaviour {

//    private InterstitialAd interstitial;

//    public static InterstitialAdManager instance;

//    void Start ()
//    {
//        instance = this;
//    #if UNITY_ANDROID
//        string appId = "ca-app-pub-2801496092032935~9279165122";
//#elif UNITY_IPHONE
//            string appId = "";
//#else
//            string appId = "unexpected_platform";
//#endif

//        // Initialize the Google Mobile Ads SDK.
//        MobileAds.Initialize(appId);
//        this.RequestInterstitial();

//    }
   
//    private void RequestInterstitial()
//    {
//            #if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-2801496092032935/2259951895";
//#elif UNITY_IPHONE
//        string adUnitId = "";
//#else
//        string adUnitId = "unexpected_platform";
//#endif

//        // Initialize an InterstitialAd.
//        interstitial = new InterstitialAd(adUnitId);


//        // Called when an ad request has successfully loaded.
//        interstitial.OnAdLoaded += HandleOnAdLoaded;
//        // Called when an ad request failed to load.
//        interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
//        // Called when an ad is shown.
//        interstitial.OnAdOpening += HandleOnAdOpened;
//        // Called when the ad is closed.
//        interstitial.OnAdClosed += HandleOnAdClosed;
//        // Called when the ad click caused the user to leave the application.
//        interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;


//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the interstitial with the request.
//        interstitial.LoadAd(request);
        
//    }

//    public void HandleOnAdLoaded(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleAdLoaded event received");
//    }

//    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//    {
//        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
//                            + args.Message);
//    }

//    public void HandleOnAdOpened(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleAdOpened event received");
//    }

//    public void HandleOnAdClosed(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleAdClosed event received");
//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the interstitial with the request.
//        interstitial.LoadAd(request);
//    }

//    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleAdLeavingApplication event received");
//    }



//    public void ShowAd()
//    {

//        if (interstitial.IsLoaded())

//        {
//           interstitial.Show();
//            Debug.Log("Inter Ad is showing ");
//        }
//        else
//        {
//            interstitial.Destroy();
//            Debug.Log("Inter Ad is not showing ");

//        }

//    }
//    public void GameOver()
//    {
  
//        if (interstitial.IsLoaded())
//        {
//            interstitial.Show();
//            interstitial.Destroy();
//        }
//    }
//}
