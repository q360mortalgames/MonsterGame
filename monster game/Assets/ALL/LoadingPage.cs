﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingPage : MonoBehaviour 
{

	void Start()
	{
		StartCoroutine(LoadYourAsyncScene());
	}

	IEnumerator LoadYourAsyncScene()
	{

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("startpage");
      
        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
		{
			yield return null;
		}
	}

}
