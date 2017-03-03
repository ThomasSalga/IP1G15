using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	//[SerializeField] private
	public GameObject pausePanel;
	void Start()
	{
		pausePanel.SetActive(false);
	}
	void Update()
	{
		if (!pausePanel.activeInHierarchy) {
			
			if (Input.GetKeyDown (KeyCode.Escape)) {
			
		
				if (!pausePanel.activeInHierarchy) {
					//Debug.Log ("Game Paused");
					StartCoroutine (PauseGame ());
					//PauseGame ();

				}

			}



		}


		if (pausePanel.activeInHierarchy) {

			if (Input.GetKeyDown (KeyCode.Escape)) {

		
			
				if (pausePanel.activeInHierarchy) {
					//Debug.Log ("Game Resumed");
					StartCoroutine (ContinueGame ());   

				}
			} 
		}
	}

	//private void PauseGame()
	IEnumerator PauseGame()
	{
		Time.timeScale = 0;
		pausePanel.SetActive(true);
		Debug.Log ("Game Paused");
		//Disable scripts that still work while timescale is set to 0
		yield return new WaitForSecondsRealtime(2);
	} 
	IEnumerator ContinueGame()
	{
		Time.timeScale = 1;
		pausePanel.SetActive(false);
		Debug.Log ("Game Resumed");
		yield return new WaitForSecondsRealtime(2);
		//enable the scripts again
	}
}
