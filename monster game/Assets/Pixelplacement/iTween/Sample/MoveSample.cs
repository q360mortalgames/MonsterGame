using UnityEngine;
using System.Collections;

  
public class MoveSample : MonoBehaviour
{	

	public GameObject Title;
	void Start()
	{
		iTween.MoveTo(Title.gameObject, iTween.Hash("x", -1, "y", 0, "z", 0, "islocal", true, "time", 0.25, "delay", 0.5, "easetype", iTween.EaseType.linear));
	}
}

