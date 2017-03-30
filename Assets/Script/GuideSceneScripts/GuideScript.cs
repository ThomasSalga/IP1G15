using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GuideScript : MonoBehaviour {

	GameObject building1Info;
	GameObject building2Info;
	GameObject building3Info;
	GameObject building4Info;
	GameObject building5Info;
	GameObject enemy1Info;
	GameObject enemy2Info;
	GameObject enemy7Info;
	GameObject enemy8Info;
	GameObject enemy1On;
	GameObject enemy2On;
	GameObject enemy7On;
	GameObject enemy8On;
	GameObject building1On;
	GameObject building2On;
	GameObject building3On;
	GameObject building4On;
	GameObject building5On;

	// Use this for initialization
	void Start () {
		building1Info =	GameObject.Find ("HamishWoodInfo");
		building1Info.SetActive (false);

		building2Info =	GameObject.Find ("GeorgeMooreInfo");
		building2Info.SetActive (false);

		building3Info =	GameObject.Find ("GovanMbekiInfo");
		building3Info.SetActive (false);

		building4Info =	GameObject.Find ("CaledonianCourtInfo");
		building4Info.SetActive (false);

		building5Info =	GameObject.Find ("CharlesOakleyInfo");
		building5Info.SetActive (false);

		enemy1Info = GameObject.Find ("NormalStoneInfo");
		enemy1Info.SetActive (false);

		enemy2Info = GameObject.Find ("StrongerStoneInfo");
		enemy2Info.SetActive (false);

		enemy7Info = GameObject.Find ("NormalIceInfo");
		enemy7Info.SetActive (false);

		enemy8Info = GameObject.Find ("StrongerIceInfo");
		enemy8Info.SetActive (false);

		enemy1On = GameObject.Find ("Enemy1On");
		enemy1On.SetActive (true);

		enemy2On = GameObject.Find ("Enemy2On");
		enemy2On.SetActive (true);

		enemy7On = GameObject.Find ("Enemy7On");
		enemy7On.SetActive (true);

		enemy8On = GameObject.Find ("Enemy8On");
		enemy8On.SetActive (true);

		building1On = GameObject.Find ("Building1On");
		building1On.SetActive (true);

		building2On = GameObject.Find ("Building2On");
		building2On.SetActive (true);

		building3On = GameObject.Find ("Building3On");
		building3On.SetActive (true);

		building4On = GameObject.Find ("Building4On");
		building4On.SetActive (true);

		building5On = GameObject.Find ("Building5On");
		building5On.SetActive (true);

	}

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
		building1On.SetActive (true);
		building1Info.SetActive (false);
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
		building2On.SetActive (true);
		building2Info.SetActive (false);
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
		building3On.SetActive (true);
		building3Info.SetActive (false);
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
		building4On.SetActive (true);
		building4Info.SetActive (false);
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
		building5On.SetActive (true);
		building5Info.SetActive (false);
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





	public void ReturnToMainMenu(){

		SceneManager.LoadScene ("MainMenuScene");


	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
