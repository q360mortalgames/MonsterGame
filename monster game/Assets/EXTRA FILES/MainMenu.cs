using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject AboutUs;
	public GameObject MoreGames;
	public GameObject TaptoPlay;
	public GameObject Exit;


	public void AboutusPage ()
	{
		AboutUs.SetActive (true);

	}

	public void AboutusBack()
	{
		AboutUs.SetActive (false);	
	}
	public void MoreGamesPage()
	{
		Application.OpenURL ("https://play.google.com/store/apps/dev?id=7117847536434853747");

	}


	public void TaptoplayPage()
	{
	//	AdManager.Instance.InterADS ();
	//	Debug.Log ("InterAD");
		SceneManager.LoadScene ("BikeMenu");

	}

	public void ExitPage()
	{
		Application.Quit ();

	}



}
