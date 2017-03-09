using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour 
{
	public GameObject pausePanel;
	public GameObject effectCamera;



	void Start()
	{

		effectCamera.SetActive(false);
		pausePanel.SetActive(false);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausePanel.activeInHierarchy)
            {
                if (!pausePanel.activeInHierarchy)
                    StartCoroutine(PauseGame());
            }
            else StartCoroutine(ContinueGame());
        }


       // if (Input.GetKeyDown(KeyCode.Escape)) // you were calling twice in the same frame that's why was pausing and unpausing 
       // {
       //     if (pausePanel.activeInHierarchy)
       //     {
       //         if (pausePanel.activeInHierarchy) // you are controlling twice the same thing
       //         {
       //             StartCoroutine (ContinueGame ());  
       //         }
       //     }
       // }
	}

	//private void PauseGame()
	IEnumerator PauseGame()
	{
		Time.timeScale = 0;
		pausePanel.SetActive(true);
		effectCamera.SetActive(true);
		Debug.Log ("Game Paused");
		//Disable scripts that still work while timescale is set to 0
		yield return new WaitForSecondsRealtime(2);
	} 
	IEnumerator ContinueGame()
	{
		Time.timeScale = 1;
		pausePanel.SetActive(false);
		effectCamera.SetActive(false);
		Debug.Log ("Game Resumed");
		yield return new WaitForSecondsRealtime(2);
		//enable the scripts again
	}

	public void PausePress(){
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
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().clip.length);
		Debug.Log ("The click worked.");
		SceneManager.LoadScene ("MainMenuScene");
	}


}


