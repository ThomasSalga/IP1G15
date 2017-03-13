using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour 
{
	public GameObject pausePanel;
	public GameObject effectCamera;
	public GameObject pauseButton;
	public AudioSource clickSound;



	void Start()
	{
		effectCamera.SetActive(false);
		pausePanel.SetActive(false);
		pauseButton.SetActive(true);
	}

	void Update()
	{
		
        }




	//private void PauseGame()
	IEnumerator PauseGame()
	{
		Time.timeScale = 0;
		pausePanel.SetActive(true);
		effectCamera.SetActive(true);
		pauseButton.SetActive(false);
		Debug.Log ("Game Paused");
		//Disable scripts that still work while timescale is set to 0
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
	} 
	IEnumerator ContinueGame()
	{
		Time.timeScale = 1;
		pausePanel.SetActive(false);
		effectCamera.SetActive(false);
		pauseButton.SetActive(true);
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
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		//SceneManager.LoadScene ("MainLevel");
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


