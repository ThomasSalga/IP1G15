using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneScript : MonoBehaviour {


	//public double previousLevel;

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


	public void Restart(){

		StartCoroutine (DelayRestart());

	}

	IEnumerator DelayRestart(){

	
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("MainLevel");
	}


	public void ReturnToMainMenu(){

		StartCoroutine (DelayReturnToMainMenu());


	}



	IEnumerator DelayReturnToMainMenu(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("MainMenuScene");
	}



}
