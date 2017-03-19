using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour 
{
	public GameObject pausePanel;
	public GameObject effectCamera;
	public AudioSource clickSound;
	public GameObject restartToggle;
	public GameObject mainCanvas;
	public GameObject musicPlaying;
	public GameObject warning;
	public float appearTime;
	public float disappearTime;





	void Start()
	{
		mainCanvas.SetActive (true);
		restartToggle.SetActive(false);
		effectCamera.SetActive(false);
		pausePanel.SetActive(false);
		warning.SetActive(false);
		Time.timeScale = 1;
		StartCoroutine(WarningAppear());
		StartCoroutine (WarningDisappear());
	}

	void Update()
	{
		
        }


	IEnumerator WarningAppear()
	{
		yield return new WaitForSeconds(appearTime);
		warning.SetActive(true);

	}

	IEnumerator WarningDisappear()
	{
		yield return new WaitForSeconds(disappearTime);
		warning.SetActive(false);

	}



	//private void PauseGame()
	IEnumerator PauseGame()
	{
		musicPlaying.GetComponent<AudioSource> ().Pause();
		Time.timeScale = 0;
		mainCanvas.SetActive (false);
		pausePanel.SetActive(true);
		effectCamera.SetActive(true);
		Debug.Log ("Game Paused");
		//Disable scripts that still work while timescale is set to 0
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
	}

	IEnumerator ContinueGame()
	{
		musicPlaying.GetComponent<AudioSource> ().Play();
		Time.timeScale = 1;
		mainCanvas.SetActive (true);
		pausePanel.SetActive(false);
		effectCamera.SetActive(false);
		Debug.Log ("Game Resumed");
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);

		//enable the scripts again
	}

	public void PausePress(){

	
		clickSound.Play();

	if (!pausePanel.activeInHierarchy)
	{
		if (!pausePanel.activeInHierarchy)
			StartCoroutine(PauseGame());
	}
	else StartCoroutine(ContinueGame());
}





	public void GoToGuide(){
			StartCoroutine (DelayGoToGuide());
		}
		IEnumerator DelayGoToGuide(){
		Time.timeScale = 1;
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		SceneManager.LoadScene ("GuideScene");
	}


	public void Restart(){
		StartCoroutine (DelayRestart());
	}

	IEnumerator DelayRestart(){
		Time.timeScale = 1;
		restartToggle.SetActive(true);
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		Debug.Log ("The click worked.");
		SceneManager.LoadScene ("MainLevel");
	}


	public void ReturnToMainMenu(){
		StartCoroutine (DelayReturnToMainMenu());
	}

	IEnumerator DelayReturnToMainMenu(){
		Time.timeScale = 1;
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		Debug.Log ("The click worked.");
		SceneManager.LoadScene ("MainMenuScene");
	}


}


