using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class startMenu : MonoBehaviour {

    // Use this for initialization

    public GameObject Exit;
    public GameObject TaptoPlay;
    public GameObject title, Racing, RRR, number, settings_btn, Achi_btn, Leader_btn,ratebtn,moregamesbtn;
    public Image Bg_image;
    public GameObject startbike;
    public GameObject Loadingtext;

    bool ImgBool = false;
    public static bool settingBool = false;

    private void Awake()
    {
        
        if (ImgBool == false)
        {
            Bg_image.CrossFadeAlpha(0, 0.01f, false);
            ImgBool = true;
        }

    }
    void Start()
    {
        
        if (ImgBool == true)
        {
            print("................");
            Bg_image.CrossFadeAlpha(1, 2f, false);
        }
        iTween.MoveFrom(title, iTween.Hash("y", 2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.1));
        iTween.MoveFrom(Racing, iTween.Hash("x", 2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.5f));
        iTween.MoveFrom(RRR, iTween.Hash("x", 2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.5f));
        iTween.MoveFrom(number, iTween.Hash("x", 2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.5f));
        iTween.MoveFrom(TaptoPlay, iTween.Hash("y", -1000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.1));

        iTween.MoveFrom(settings_btn, iTween.Hash("x", -2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.5f));
        iTween.MoveFrom(Leader_btn, iTween.Hash("x", -2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.6f));
        iTween.MoveFrom(Achi_btn, iTween.Hash("x", -2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.7f));
        iTween.MoveFrom(moregamesbtn, iTween.Hash("x", -2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.7f));
        iTween.MoveFrom(ratebtn, iTween.Hash("x", -2000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.7f));

    }

   public void SettingPage() {

        settingBool = true;
        Application.LoadLevel("CarMenu");

    }

    void Update()
	{

        //	StartCoroutine(LoadYourAsyncScene());

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

	IEnumerator LoadYourAsyncScene()
	{
		
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("CarMenu");
    //    Debug.Log("Hide banner");
     //   GoogleAdMobBanner.instance.HideThisBanner();
		// Wait until the asynchronous scene fully loads
		while (!asyncLoad.isDone)
		{
			yield return null;
		}
	}



    public void MoreGamesPage()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=7117847536434853747");
    }

    public void RateIt()
    {

        //  Application.OpenURL("");
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.sevenseas.bikeracing2019");

    }
    public void Play()
    {

        Loadingtext.SetActive(true);
        StartCoroutine(LoadYourAsyncScene());
     }

	public void ExitGame ()
	{
       Application.Quit ();
	}
    public void pp()
    {
        Application.OpenURL("https://racingautovehiclegames.blogspot.com/");
    }
}
