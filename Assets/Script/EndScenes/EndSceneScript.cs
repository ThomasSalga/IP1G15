using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneScript : MonoBehaviour {


	public GameObject enemyBase;

	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void Update () {

	}


	public void Restart(){

		GameObject.Find ("EnemyBase").SetActive(false);
		Time.timeScale = 1;
		StartCoroutine (DelayRestart());

	}

	IEnumerator DelayRestart(){

	
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Debug.Log ("restartclicked");
	}


	public void ReturnToMainMenu(){

		GameObject.Find ("EnemyBase").SetActive(false);
		Time.timeScale = 1;
		StartCoroutine (DelayReturnToMainMenu());


	}





	IEnumerator DelayReturnToMainMenu(){

	
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("MainMenuScene");
	}



}
