using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataScriptOld : MonoBehaviour {


	public Slider volslider;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	
		GameObject.Find ("OptionsMenuObject").GetComponent<OptionsMenuScript>();
		//OptionsMenuScript.
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
