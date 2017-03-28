using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenSceneScript : MonoBehaviour {
	


	// Use this for initialization
	void Start () {




		StartCoroutine(DelayLoad());


	}


	IEnumerator DelayLoad(){

		yield return new WaitForSecondsRealtime (5f);

		SceneManager.LoadScene ("MainMenuScene");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
