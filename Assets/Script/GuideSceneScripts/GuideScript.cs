using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GuideScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void ReturnToMainMenu(){

		SceneManager.LoadScene ("MainMenuScene");


	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
