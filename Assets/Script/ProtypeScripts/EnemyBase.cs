using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyBase : MonoBehaviour {

	public GameObject mainCanvas;
	public GameObject effectCamera;
	public GameObject winCanvas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject[] listEnemy;
        listEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        
		if (listEnemy.Length == 0)
			WinGame ();
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag != "Enemy") {
			Destroy (other.gameObject);


		} else {
			//GetComponent<AudioSource>().Play ();
		}
	}



	public void WinGame(){



		mainCanvas.SetActive (false);
		effectCamera.SetActive(true);

		GameObject.Find ("MusicPlaying").GetComponent<AudioSource> ().Stop ();

		GameObject.Find ("EndMusic").GetComponent<AudioSource> ().Play ();

		winCanvas.SetActive (true);

		Time.timeScale = 0;

	}

}
