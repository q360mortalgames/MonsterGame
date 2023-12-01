//using UnityEngine;
//using GoogleMobileAds.Api;
//using System;
//using UnityEngine.UI;


//public class RewardVideoManager : MonoBehaviour {

//    private RewardBasedVideoAd rewardBasedVideo;
//    public Text addReward;
//    void Start () {

//#if UNITY_ANDROID
//        string appId = "ca-app-pub-2801496092032935~9279165122";
//#elif UNITY_IPHONE
//            string appId = "";
//#else
//            string appId = "unexpected_platform";
//#endif

//        // Get singleton reward based video ad reference.
//        this.rewardBasedVideo = RewardBasedVideoAd.Instance;

//        // Called when an ad request has successfully loaded.
//        rewardBasedVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
//        // Called when an ad request failed to load.
//        rewardBasedVideo.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
//        // Called when an ad is shown.
//        rewardBasedVideo.OnAdOpening += HandleRewardBasedVideoOpened;
//        // Called when the ad starts to play.
//        rewardBasedVideo.OnAdStarted += HandleRewardBasedVideoStarted;
//        // Called when the user should be rewarded for watching a video.
//        rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
//        // Called when the ad is closed.
//        rewardBasedVideo.OnAdClosed += HandleRewardBasedVideoClosed;
//        // Called when the ad click caused the user to leave the application.
//        rewardBasedVideo.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;

//        MobileAds.Initialize(appId);

//        this.RequestRewardBasedVideo();

//    }

//    private void RequestRewardBasedVideo()
//    {
//#if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-2801496092032935/7880369266";
//#elif UNITY_IPHONE
//            string adUnitId = "ca-app-pub-2801496092032935/7880369266";
//#else
//            string adUnitId = "unexpected_platform";
//#endif

//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the rewarded video ad with the request.
//        this.rewardBasedVideo.LoadAd(request, adUnitId);
//    }


//    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
//    }

//    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//    {
//        MonoBehaviour.print(
//            "HandleRewardBasedVideoFailedToLoad event received with message: "
//                             + args.Message);
//    }

//    public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
//    }

//    public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
//    }

//    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
//        this.RequestRewardBasedVideo();
//    }
    
//    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
//    {
//        string type = args.Type;
//        double amount = args.Amount;
//        MonoBehaviour.print(
//            "HandleRewardBasedVideoRewarded event received for "
//                        + amount.ToString() + "Currency " + type);
//        RGSK.PlayerData.AddCurrency(250);
//        addReward.text = "Reward with added  250";
       
//    }

//    public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
//    {
//        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
//    }


//    public void ShowRewardVideo()
//    {
//        if (rewardBasedVideo.IsLoaded())
//        {
//            rewardBasedVideo.Show();
//        }
//    }
//}
