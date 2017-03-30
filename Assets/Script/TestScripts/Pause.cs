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
	public GameObject guide;


	public GameObject building1Info;
	public GameObject building2Info;
	public GameObject building3Info;
	public GameObject building4Info;
	public GameObject building5Info;
	public GameObject enemy1Info;
	public GameObject enemy2Info;
	public GameObject enemy7Info;
	public GameObject enemy8Info;
	public GameObject enemy1On;
	public GameObject enemy2On;
	public GameObject enemy7On;
	public GameObject enemy8On;
	public GameObject building1On;
	public GameObject building2On;
	public GameObject building3On;
	public GameObject building4On;
	public GameObject building5On;

	// Use this for initialization


	public void OpenBuilding1(){
		building1Info.SetActive (true);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (false);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);
	}
	public void CloseBuilding1(){

		building1Info.SetActive (false);
		building1On.SetActive (true);
	}

	public void OpenBuilding2(){
		building1Info.SetActive (false);
		building2Info.SetActive (true);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (false);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);
	}
	public void CloseBuilding2(){
		building2Info.SetActive (false);
		building2On.SetActive (true);
	}

	public void OpenBuilding3(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (true);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (false);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);
	}
	public void CloseBuilding3(){
		building3Info.SetActive (false);
		building3On.SetActive (true);
	}

	public void OpenBuilding4(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (true);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (false);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);
	}
	public void CloseBuilding4(){
		building4Info.SetActive (false);
		building4On.SetActive (true);
	}

	public void OpenBuilding5(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (true);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (false);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);
	}
	public void CloseBuilding5(){
		building5Info.SetActive (false);
		building5On.SetActive (true);
	}

	public void OpenEnemy1(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (true);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (false);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);

	}
	public void CloseEnemy1(){
		enemy1Info.SetActive (false);
		enemy1On.SetActive (true);
	}

	public void OpenEnemy2(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (true);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (false);
		enemy7On.SetActive (true);
		enemy8On.SetActive (true);

	}
	public void CloseEnemy2(){
		enemy2Info.SetActive (false);
		enemy2On.SetActive (true);
	}

	public void OpenEnemy7(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (true);
		enemy8Info.SetActive (false);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (false);
		enemy8On.SetActive (true);

	}
	public void CloseEnemy7(){
		enemy7Info.SetActive (false);
		enemy7On.SetActive (true);
	}

	public void OpenEnemy8(){
		building1Info.SetActive (false);
		building2Info.SetActive (false);
		building3Info.SetActive (false);
		building4Info.SetActive (false);
		building5Info.SetActive (false);
		enemy1Info.SetActive (false);
		enemy2Info.SetActive (false);
		enemy7Info.SetActive (false);
		enemy8Info.SetActive (true);
		building1On.SetActive (true);
		building2On.SetActive (true);
		building3On.SetActive (true);
		building4On.SetActive (true);
		building5On.SetActive (true);
		enemy1On.SetActive (true);
		enemy2On.SetActive (true);
		enemy7On.SetActive (true);
		enemy8On.SetActive (false);
	}
	public void CloseEnemy8(){
		enemy8Info.SetActive (false);
		enemy8On.SetActive (true);
	}






	// Update is called once per frame
	void Update () {

	}



	void Start () {
			//building1Info =	GameObject.Find ("HamishWoodInfo");
			building1Info.SetActive (false);

			//building2Info =	GameObject.Find ("GeorgeMooreInfo");
			building2Info.SetActive (false);

			//building3Info =	GameObject.Find ("GovanMbekiInfo");
			building3Info.SetActive (false);

			//building4Info =	GameObject.Find ("CaledonianCourtInfo");
			building4Info.SetActive (false);

			//building5Info =	GameObject.Find ("CharlesOakleyInfo");
			building5Info.SetActive (false);

			//enemy1Info = GameObject.Find ("NormalStoneInfo");
			enemy1Info.SetActive (false);

			//enemy2Info = GameObject.Find ("StrongerStoneInfo");
			enemy2Info.SetActive (false);

			//enemy7Info = GameObject.Find ("NormalIceInfo");
			enemy7Info.SetActive (false);

			//enemy8Info = GameObject.Find ("StrongerIceInfo");
			enemy8Info.SetActive (false);

			//enemy1On = GameObject.Find ("Enemy1On");
			enemy1On.SetActive (true);

			//enemy2On = GameObject.Find ("Enemy2On");
			enemy2On.SetActive (true);

			//enemy7On = GameObject.Find ("Enemy7On");
			enemy7On.SetActive (true);

		//	enemy8On = GameObject.Find ("Enemy8On");
			enemy8On.SetActive (true);

		

		guide.SetActive(false);
		mainCanvas.SetActive (true);
		restartToggle.SetActive(false);
		effectCamera.SetActive(false);
		pausePanel.SetActive(false);
		warning.SetActive(false);
		Time.timeScale = 1;
		StartCoroutine(WarningAppear());
		StartCoroutine (WarningDisappear());
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
			
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		//SceneManager.LoadScene ("GuideScene");
		guide.SetActive(true);
		pausePanel.SetActive (false);
		mainCanvas.SetActive (false);
		effectCamera.SetActive (false);
	
	}

	public void ExitGuide(){
		GameObject.Find ("ButtonClickObject").GetComponent<AudioSource> ().Play ();
		//SceneManager.LoadScene ("GuideScene");
		guide.SetActive(false);
		pausePanel.SetActive (true);
		effectCamera.SetActive (true);


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
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
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


