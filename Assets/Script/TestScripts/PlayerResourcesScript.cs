using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerResourcesScript : MonoBehaviour {

	//public Slider volslider;
	public int playerHealthSave;
	public int playerResourceSave;



	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);

	}
	
	// Update is called once per frame
	void Update () {
	
		GameObject.Find ("PlayerGameObject").GetComponent<Player>();
		//playerHealthSave = Player.m_life;

		GameObject.Find ("PlayerGameObject").GetComponent<Player>();
		//playerResourceSave = Player.m_resource;




	}
}
