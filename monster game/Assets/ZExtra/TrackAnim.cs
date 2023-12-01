using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackAnim : MonoBehaviour
{


    public GameObject TrackSettingbtn, RaceSettingbtn, Racebtn, lapsbtn, airacersbtn, aidiffbtn, bestlapbtn,startrace;





	// Use this for initialization
	void Start ()
    { 
         iTween.MoveFrom(TrackSettingbtn, iTween.Hash("x", -1000, "time", 0.5f, "easeType", "easeInOutQuad", "delay", 0.1f));
        iTween.MoveFrom(RaceSettingbtn, iTween.Hash("x", 2000, "time", 0.5f, "easeType", "easeInOutQuad", "delay", 0.1f));
        iTween.MoveFrom(startrace, iTween.Hash("x", 2000, "time", 0.5f, "easeType", "easeInOutQuad", "delay", 0.7f));
        iTween.MoveFrom(Racebtn, iTween.Hash("y", 3000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.1f));
        iTween.MoveFrom(lapsbtn, iTween.Hash("y", 3000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.2f));
        iTween.MoveFrom(airacersbtn, iTween.Hash("y", 3000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.3f));
        iTween.MoveFrom(aidiffbtn, iTween.Hash("y", 3000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.4f));
        iTween.MoveFrom(bestlapbtn, iTween.Hash("y", 3000, "time", 1, "easeType", "easeInOutQuad", "delay", 0.5f));


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
