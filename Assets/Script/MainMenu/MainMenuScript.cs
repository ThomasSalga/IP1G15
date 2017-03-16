using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {




	// Use this for initialization
	void Start () {
	
		/*GameObject gameData = GameObject.Find("GameDataObject");
		if (gameData == null) {

			gameData = new GameObject ("GameDataObject");
			gameData.AddComponent<GameDataScript> ();
		} else {
			GameDataScript gameDataScript = gameData.GetComponent<GameDataScript>();
			//nameInputField.text = gameDataScript.playerName;
		}*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void PlayGame(){
	
		StartCoroutine (DelayPlayGame());

	}


	public void GoOptions(){

		StartCoroutine (DelayGoOptions());


	}

	public void QuitGame(){
		StartCoroutine (DelayQuitGame ());

	}

	public void GoGuide(){

		StartCoroutine (DelayGoGuide ());
	}



	IEnumerator DelayPlayGame(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("SelectionMenuScene");


	}
	IEnumerator DelayGoOptions(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("OptionsMenuScene");
	}

	IEnumerator DelayGoGuide(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("GuideScene");
	}

	IEnumerator DelayQuitGame(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		Application.Quit();
	}

}
