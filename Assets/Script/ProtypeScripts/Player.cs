using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour, IFixable<int> {

    [SerializeField]
    private int m_maxLife;
    [SerializeField]
	private int m_life;
    [SerializeField]
    private int m_resource;

	public GameObject mainCanvas;
	public GameObject effectCamera;
	public GameObject loseCanvas;

    public int MyMaxDurability
    {
        get
        {
            return m_maxLife;
        }

        set
        {
            m_maxLife = value;
        }
    }

    public int MyDurability
    {
        get
        {
            return m_life;
        }

        set
        {
            m_life = value;
            if (m_life <= 0)
            {

				LoseGame ();

				//SceneManager.LoadScene("DeadScene");
            }
        }
    }

	public void LoseGame(){

		mainCanvas.SetActive (false);
		effectCamera.SetActive(true);

		GameObject.Find ("MusicPlaying").GetComponent<AudioSource> ().Stop ();

		GameObject.Find ("EndMusic").GetComponent<AudioSource> ().Play ();

		loseCanvas.SetActive (true);

		Time.timeScale = 0;

	}



    public int MyResource
    {
        get
        {
            return m_resource;
        }

        set
        {
            m_resource = value;
            if (m_resource < 0)
                m_resource = 0;
        }
    }

    // Use this for initialization
    void Start ()
    {
		effectCamera.SetActive(true);
		Time.timeScale = 1;
		GameObject.Find ("LoseCanvas").SetActive (false);
		GameObject.Find ("WinCanvas").SetActive (false);

	}

    void FixedUpdate()
    {
        GameObject.FindGameObjectWithTag("Resource").GetComponent<Text>().text = " " + MyResource;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage(other.GetComponent<EnemyParent>().MyDamage);
        Destroy(other.gameObject);
    }

    public void Fix(int amount)
    {
        MyDurability += amount;
    }

    public void TakeDamage(int amount)
    {
        MyDurability -= amount;
    }
}
