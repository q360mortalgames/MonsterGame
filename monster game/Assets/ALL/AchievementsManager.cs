using UnityEngine;
//using GooglePlayGames;
//using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class AchievementsManager : MonoBehaviour {

	
	void Awake() {

      //  PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
     //   PlayGamesPlatform.InitializeInstance(config);
    //    PlayGamesPlatform.Activate();
        SignIn();
	}
	
	private void SignIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("User is login sucess");
            }
            else{
                Debug.Log("User is login sucess");
            }
        });
    }

    #region Achievements

    public static void UnlockAchievement(string id, int score)
    {
        Social.ReportProgress(id, 100, (bool success) => { });
    }

    //achievement_firstwin          

    public static void Achievement_firstwin(string id, int score)
    {
        Social.ReportProgress(id, 100, (bool success) => { });
    }


    public static void Achievement_bestlaptime(string id, int score)
    {
        Social.ReportProgress(id, 100, (bool success) => { });
    }



    public static void Achievement_lapknockoutwinner(string id, int score)
    {
        Social.ReportProgress(id, 100, (bool success) => { });
    }



    public static void Achievement_circuitwinner(string id, int score)
    {
        Social.ReportProgress(id, 100, (bool success) => { });
    }


    public static void Achievement_eliminationwinner(string id, int score)
    {
        Social.ReportProgress(id, 100, (bool success) => { });
    }

   public static void IncrementalAchievement(string id, int steps)
    {
       // PlayGamesPlatform.Instance.IncrementAchievement(id, steps, (bool success) => { });
    }

    public void ShowAchievemnts()
    {
        Social.ShowAchievementsUI();
    }


    #endregion
}
