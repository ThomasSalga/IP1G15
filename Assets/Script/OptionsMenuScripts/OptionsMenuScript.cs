using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenuScript : MonoBehaviour {



	public AudioMixer masterMixer;
	public GameObject musicMute;
	public GameObject musicUnmute;
	public GameObject fxMute;
	public GameObject fxUnmute;
	public GameObject musicIcons;


	// Use this for initialization
	void Start () {

		float currentFX;
		float currentMusic;

		masterMixer.GetFloat ("FXVolume", out currentFX);
		masterMixer.GetFloat ("MusicVolume", out currentMusic);

		if (currentFX == 0 && currentMusic == 0) {
			musicMute.SetActive (true);
			musicUnmute.SetActive (false);
			fxMute.SetActive (true);
			fxUnmute.SetActive (false);
		}
		if(currentFX == 0 && currentMusic == -80) {
			musicMute.SetActive (false);
			musicUnmute.SetActive (true);
			fxMute.SetActive (true);
			fxUnmute.SetActive (false);
		}
		if (currentFX == -80 && currentMusic == 0) {
			musicMute.SetActive (true);
			musicUnmute.SetActive (false);
			fxMute.SetActive (false);
			fxUnmute.SetActive (true);
		}
		if (currentFX == -80 && currentMusic == -80) {
			musicMute.SetActive (false);
			musicUnmute.SetActive (true);
			fxMute.SetActive (false);
			fxUnmute.SetActive (true);
		}

	}
	
	// Update is called once per frame
	void Update () {



	}


	public void FXMute(){


		masterMixer.SetFloat ("FXVolume", -80);
		fxMute.SetActive (false);
		fxUnmute.SetActive (true);

	}

	public void FXUnmute(){
		
			masterMixer.SetFloat ("FXVolume", 0);
			fxMute.SetActive (true);
			fxUnmute.SetActive (false);
	}


	public void MusicMute(){

		musicIcons.SetActive (false);
		masterMixer.SetFloat ("MusicVolume", -80);
		musicMute.SetActive (false);
		musicUnmute.SetActive (true);

}

	public void MusicUnmute(){

		musicIcons.SetActive (true);
		masterMixer.SetFloat ("MusicVolume", 0);
		musicMute.SetActive (true);
		musicUnmute.SetActive (false);

	}





	/*public void SetMainVolume(float mainVolume){

		masterMixer.SetFloat ("MainVolume", mainVolume);
	}
		
	public void SetMusicVolume(float musicVolume){

		masterMixer.SetFloat ("MusicVolume", musicVolume);

	}

	public void SetSoundEffectsVolume(float soundEffectsVolume){

		masterMixer.SetFloat ("SoundEffectsVolume", soundEffectsVolume);

	}*/






	public void ReturnToMainMenu(){

		StartCoroutine (DelayReturnToMainMenu ());

	}

	IEnumerator DelayReturnToMainMenu(){

		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("MainMenuScene");
	}



}
