﻿//using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine;

public class Leaderboard : MonoBehaviour {

    #region PUBLIC_VAR
    public string leaderboard;
    #endregion
    #region DEFAULT_UNITY_CALLBACKS
    void Awake()
    {
        // recommended for debugging:
      //  PlayGamesPlatform.DebugLogEnabled = true;

        // Activate the Google Play Games platform
    //    PlayGamesPlatform.Activate();
        LogIn();
    }
    #endregion
    #region BUTTON_CALLBACKS
    /// <summary>
    /// Login In Into Your Google+ Account
    /// </summary>
    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("Login Sucess");
                OnAddScoreToLeaderBorad();
            }
            else
            {
                Debug.Log("Login failed");
            }
        });
    }
    /// <summary>
    /// Shows All Available Leaderborad
    /// </summary>
    public void OnShowLeaderBoard()
    {
        //        Social.ShowLeaderboardUI (); // Show all leaderboard
      //  ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard); // Show current (Active) leaderboard
    }
    /// <summary>
    /// Adds Score To leader board
    /// </summary>
    public void OnAddScoreToLeaderBorad()
    {
        if (Social.localUser.authenticated)
        {
            Social.ReportScore(100, leaderboard, (bool success) =>
            {
                if (success)
                {

                    RGSK.PlayerData.SaveCurrency();
                    Debug.Log("Update Score Success");

                }
                else
                {

                    RGSK.PlayerData.LoadCurrency();
                    Debug.Log("Update Score Fail");
                }
            });
        }
    }
    /// <summary>
    /// On Logout of your Google+ Account
    /// </summary>
    public void OnLogOut()
    {
       // ((PlayGamesPlatform)Social.Active).SignOut();
    }
    #endregion
}