using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthResource : MonoBehaviour {


    GameObject m_player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");

        gameObject.GetComponent<Text>().text = " " + m_player.GetComponent<Player>().MyDurability;

    }
}
