using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public GameObject pausePanel;
	void Start()
	{
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
