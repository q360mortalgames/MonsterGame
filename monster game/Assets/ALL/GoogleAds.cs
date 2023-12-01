//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using GoogleMobileAds.Api;
//using System;

//public class GoogleAds : MonoBehaviour {

//	public string AppID, BannerID, InterestialID, RewardID;
//	private BannerView bannerView;
//	private InterstitialAd interstitial;
//	private RewardBasedVideoAd rewardBasedVideo;
//	private float deltaTime = 0.0f;
//	private static string outputMessage = string.Empty;

//	public static GoogleAds Instance;

//	bool isShowBanner = true;

//	public static string OutputMessage
//	{
//		set { outputMessage = value; }
//	}

//	 void Start()
//	{
		
//		Instance = this;

//		if (Instance == null)
//			Instance = this;

//		DontDestroyOnLoad(this);



//		#if UNITY_ANDROID
//		string appId = AppID;
//#elif UNITY_IPHONE
//		string appId = AppID;
//#else
//		string appId = "unexpected_platform";
//#endif
     
//       // MobileAds.SetiOSAppPauseOnBackground(true);

//		// Initialize the Google Mobile Ads SDK.
//		MobileAds.Initialize(appId);

//		// Get singleton reward based video ad reference.
//		this.rewardBasedVideo = RewardBasedVideoAd.Instance;

//		// RewardBasedVideoAd is a singleton, so handlers should only be registered once.
//		this.rewardBasedVideo.OnAdLoaded += this.HandleRewardBasedVideoLoaded;
//		this.rewardBasedVideo.OnAdFailedToLoad += this.HandleRewardBasedVideoFailedToLoad;
//		this.rewardBasedVideo.OnAdOpening += this.HandleRewardBasedVideoOpened;
//		this.rewardBasedVideo.OnAdStarted += this.HandleRewardBasedVideoStarted;
//		this.rewardBasedVideo.OnAdRewarded += this.HandleRewardBasedVideoRewarded;
//		this.rewardBasedVideo.OnAdClosed += this.HandleRewardBasedVideoClosed;
//		this.rewardBasedVideo.OnAdLeavingApplication += this.HandleRewardBasedVideoLeftApplication;

//		RequestBanner ();///
//		//ShowBanner ();///
//		RequestInterstitial ();
//		RequestRewardBasedVideo ();

//		}

//	   void Update()
//		{
//		// Calculate simple moving average for time to render screen. 0.1 factor used as smoothing
//		// value.
		
		
//		}

//		// Returns an ad request with custom ad targeting.
////		private AdRequest CreateAdRequest()
////		{
////		return new AdRequest.Builder()
////		.AddTestDevice(AdRequest.TestDeviceSimulator)
////		.AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
////		.AddKeyword("game")
////		.SetGender(Gender.Male)
////		.SetBirthday(new DateTime(1985, 1, 1))
////		.TagForChildDirectedTreatment(false)
////		.AddExtra("color_bg", "9B30FF")
////		.Build();
////		}

//		public void RequestBanner()
//		{
//		// These ad units are configured to always serve test ads.
//		#if UNITY_EDITOR
//		string adUnitId = BannerID;
//		#elif UNITY_ANDROID
//		string adUnitId = "ca-app-pub-2801496092032935/7025321359";
//		#elif UNITY_IPHONE
//		string adUnitId = BannerID;
//		#else
//		string adUnitId = "unexpected_platform";
//		#endif

//		// Clean up banner ad before creating a new one.
//     	if (this.bannerView != null)
//		{
//		this.bannerView.Destroy();
//		}

//		// Create a 320x50 banner at the top of the screen.
//		this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top);

//		// Register for ad events.
//		this.bannerView.OnAdLoaded += this.HandleAdLoaded;
//		this.bannerView.OnAdFailedToLoad += this.HandleAdFailedToLoad;
//		this.bannerView.OnAdOpening += this.HandleAdOpened;
//		this.bannerView.OnAdClosed += this.HandleAdClosed;
//		this.bannerView.OnAdLeavingApplication += this.HandleAdLeftApplication;

//		// Load a banner ad.
//		AdRequest request = new AdRequest.Builder().Build();
//		this.bannerView.LoadAd(request);
//		var adsize = new AdSize (320, 50);


//		bannerView = new BannerView (BannerID, adsize, AdPosition.Top);
//		}

//		public void RequestInterstitial()
//		{
//		// These ad units are configured to always serve test ads.
//		#if UNITY_EDITOR
//		string adUnitId = InterestialID;
//		#elif UNITY_ANDROID
//		string adUnitId = "ca-app-pub-2801496092032935/2925869215";
//		#elif UNITY_IPHONE
//		string adUnitId = InterestialID;
//		#else
//		string adUnitId = "unexpected_platform";
//		#endif

//		// Clean up interstitial ad before creating a new one.
//		if (this.interstitial != null)
//		{
//		this.interstitial.Destroy();
//		}

//		// Create an interstitial.
//		this.interstitial = new InterstitialAd(adUnitId);

//		// Register for ad events.
//		this.interstitial.OnAdLoaded += this.HandleInterstitialLoaded;
//		this.interstitial.OnAdFailedToLoad += this.HandleInterstitialFailedToLoad;
//		this.interstitial.OnAdOpening += this.HandleInterstitialOpened;
//		this.interstitial.OnAdClosed += this.HandleInterstitialClosed;
//		this.interstitial.OnAdLeavingApplication += this.HandleInterstitialLeftApplication;

//		// Load an interstitial ad.
//		AdRequest request = new AdRequest.Builder().Build();
//		this.interstitial.LoadAd(request);
//		}

//		public void RequestRewardBasedVideo()
//		{
//		#if UNITY_EDITOR
//		string adUnitId = RewardID;
//		#elif UNITY_ANDROID
//		string adUnitId = "ca-app-pub-2801496092032935/5464827671";
//		#elif UNITY_IPHONE
//		string adUnitId = RewardID;
//		#else
//		string adUnitId = "unexpected_platform";
//		#endif
//		AdRequest request = new AdRequest.Builder().Build();
//		this.rewardBasedVideo.LoadAd(request, adUnitId);
//		}

//   public void ShowBanner()
//	{
//		bannerView = new BannerView (BannerID, AdSize.Banner, AdPosition.Top);
//		AdRequest request = new AdRequest.Builder ().Build ();
//		bannerView.LoadAd (request);
//	}

//	public void Show()
//	{
//		bannerView.Show ();
//	}

//	public void Hide()
//	{
//		bannerView.Hide ();
//	}

//	public void DestroyBanner()
//	{	
//		//bannerView.Hide ();
//		bannerView.Destroy ();
//	}

//		public void ShowInterstitial()
//		{
//		if (this.interstitial.IsLoaded())
//		{
//		this.interstitial.Show();
//			RequestInterstitial ();
//		}
//	//else if(AdColonyAds.Instance.Ad != null)
//	//	{
//	//	Debug.Log("Show AdColony Ad");
//	//	AdColonyAds.Instance.AdcolonyShowInterestial ();
//	//	AdColonyAds.Instance.AdcolonyAdRequest ();
//	//	}
//		}

//		public void ShowRewardBasedVideo()
//		{
//		if (this.rewardBasedVideo.IsLoaded())
//		{
//		 this.rewardBasedVideo.Show();
//	    	Debug.Log("video admob video Ad");
//			RequestRewardBasedVideo ();
//		}
//	//	else if(AdColonyAds.Instance.Ad != null)
//	//	{
//	//		AdColonyAds.Instance.AdcolonyShowRewardVideo ();
//	//		AdColonyAds.Instance.AdcolonyAdRequestForReward ();
//	//	Debug.Log("video AdColony Ad");

//	//	}
//		}

//		#region Banner callback handlers

//		public void HandleAdLoaded(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleAdLoaded event received");
//		}

//		public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//		{
//		MonoBehaviour.print("HandleFailedToReceiveAd event received with message: " + args.Message);
//		}

//		public void HandleAdOpened(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleAdOpened event received");
//		}

//		public void HandleAdClosed(object sender, EventArgs args)
//		{

//		 MonoBehaviour.print("HandleAdClosed event received");

//		}

//		public void HandleAdLeftApplication(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleAdLeftApplication event received");
//		}

//		#endregion

//		#region Interstitial callback handlers

//		public void HandleInterstitialLoaded(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleInterstitialLoaded event received");
//		}

//		public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//		{
//		MonoBehaviour.print(
//		"HandleInterstitialFailedToLoad event received with message: " + args.Message);
//		}

//		public void HandleInterstitialOpened(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleInterstitialOpened event received");
//		}

//		public void HandleInterstitialClosed(object sender, EventArgs args)
//		{

//		MonoBehaviour.print("HandleInterstitialClosed event received");

		 
//		}

//		public void HandleInterstitialLeftApplication(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleInterstitialLeftApplication event received");
//		}

//		#endregion

//		#region RewardBasedVideo callback handlers

//		public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
//		}

//		public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//		{
//		MonoBehaviour.print(
//		"HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);
//		}

//		public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
//		}

//		public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
//		}

//		public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
//		}

//		public void HandleRewardBasedVideoRewarded(object sender, Reward args)
//		{
//        //		Menu.instance.OnCallBackVideo ();


       


//        string type = args.Type;
//		double amount = args.Amount;
//		MonoBehaviour.print(
//		"HandleRewardBasedVideoRewarded event received for " + amount.ToString() + " " + type);
//		}

//		public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
//		{
//		MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
//		}
//		#endregion
//		}
