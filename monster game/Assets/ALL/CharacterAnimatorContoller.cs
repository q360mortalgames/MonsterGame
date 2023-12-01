using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RGSK;

public class CharacterAnimatorContoller : MonoBehaviour {

	public Animator characterAnimator;

	void Start () {
		characterAnimator = this.GetComponent<Animator> ();
		characterAnimator.SetTrigger ("Idle");
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*float x = Input.GetAxis ("Horizontal");
		//float y = Input.GetAxis ("Vertical");


		if (x >= 1) {
			Debug.Log ("Horizontal 1");
			CharRightTurn ();

		} else {
			Debug.Log ("Horizontal 2");
			CharLeftTurn ();
		}*/


		
		if (Input.GetKeyDown (KeyCode.W)) {
			characterAnimator.SetTrigger ("LeftTurn");
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			characterAnimator.SetTrigger ("RightTurn");
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			characterAnimator.SetTrigger ("CharUp");
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			characterAnimator.SetTrigger ("Idle");
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			characterAnimator.SetTrigger ("Crash");
		}
	}


	public void CharRightTurn()
	{
	//	PlayerCamera.instance.tempTxt.text = characterAnimator.GetCurrentAnimatorStateInfo(0).IsName("right").ToString();
		if(!characterAnimator.GetCurrentAnimatorStateInfo(0).IsName("right"))
		characterAnimator.SetTrigger ("RightTurn");
	}


	public void CharLeftTurn()
	{
		if(!characterAnimator.GetCurrentAnimatorStateInfo(0).IsName("left"))
		characterAnimator.SetTrigger ("LeftTurn");
	}

	public void Charidle()
	{
		if(!characterAnimator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
		characterAnimator.SetTrigger ("Idle");
	}


	public void CharCrash()
	{
		characterAnimator.SetTrigger ("Crash");
	}


	public void CharUp()
	{
		characterAnimator.SetTrigger ("CharUp");
	}


}
