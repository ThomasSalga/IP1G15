using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BeginLevel1(){
		StartCoroutine (DelayBeginLevel1());
	}
	IEnumerator DelayBeginLevel1(){
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		//yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		yield return new WaitForSeconds (0.2f);
		SceneManager.LoadScene ("MainLevel");
	}

	public void BeginLevel2(){
		StartCoroutine (DelayBeginLevel2());
	}
	IEnumerator DelayBeginLevel2(){
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		//SceneManager.LoadScene ("");
	}

	public void BeginLevel3(){
		StartCoroutine (DelayBeginLevel3());
	}
	IEnumerator DelayBeginLevel3(){
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		//SceneManager.LoadScene ("");
	}

	public void BeginLevel4(){
		StartCoroutine (DelayBeginLevel4());
	}
	IEnumerator DelayBeginLevel4(){
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		//SceneManager.LoadScene ("");
	}


	public void ReturnToMainMenu(){

		StartCoroutine (DelayReturnToMainMenu());

	}

	IEnumerator DelayReturnToMainMenu(){
	GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
	yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("MainMenuScene");
	}

}
