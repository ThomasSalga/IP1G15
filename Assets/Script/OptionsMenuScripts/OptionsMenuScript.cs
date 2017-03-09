using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenuScript : MonoBehaviour {



	public AudioMixer masterMixer;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetMainVolume(float mainVolume){

		masterMixer.SetFloat ("MainVolume", mainVolume);
	}
		
	public void SetMusicVolume(float musicVolume){

		masterMixer.SetFloat ("MusicVolume", musicVolume);

	}

	public void SetSoundEffectsVolume(float soundEffectsVolume){

		masterMixer.SetFloat ("SoundEffectsVolume", soundEffectsVolume);

	}


	public void ReturnToMainMenu(){

		StartCoroutine (DelayReturnToMainMenu ());

	}

	IEnumerator DelayReturnToMainMenu(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("MainMenuScene");
	}



}
