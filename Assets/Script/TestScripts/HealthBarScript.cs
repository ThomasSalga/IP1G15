using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

	SpriteRenderer healthBar;
	public Sprite health100;
	public Sprite health95;
	public Sprite health90;
	public Sprite health85;
	public Sprite health80;
	public Sprite health75;
	public Sprite health70;
	public Sprite health65;
	public Sprite health60;
	public Sprite health55;
	public Sprite health50;
	public Sprite health45;
	public Sprite health40;
	public Sprite health35;
	public Sprite health30;
	public Sprite health25;
	public Sprite health20;
	public Sprite health15;
	public Sprite health10;
	public Sprite health05;
	public Sprite health00;


	// Use this for initialization
	void Start () {
	
		healthBar = GetComponent<SpriteRenderer>();
		healthBar.sprite = health100;
	}



	// Update is called once per frame
	void FixedUpdate () {
	
		int health = GameObject.Find ("PlayerGameObject").GetComponent<Player> ().m_life;

		if ((health <= 100) && (health >= 95)) {
			healthBar.sprite = health100;
		}
		if ((health <= 95) && (health > 90)) {
			healthBar.sprite = health95;
		}
		if ((health <= 90) && (health > 85)) {
			healthBar.sprite = health90;
		}
		if ((health <= 85) && (health > 80)) {
			healthBar.sprite = health85;
		}
		if ((health <= 80) && (health > 75)) {
			healthBar.sprite = health80;
		}
		if ((health <= 75) && (health > 70)) {
			healthBar.sprite = health75;
		}
		if ((health <= 70) && (health > 65)) {
			healthBar.sprite = health70;
		}
		if ((health <= 65) && (health > 60)) {
			healthBar.sprite = health65;
		}
		if ((health <= 60) && (health > 55)) {
			healthBar.sprite = health60;
		}
		if ((health <= 55) && (health > 50)) {
			healthBar.sprite = health55;
		}
		if ((health <= 50) && (health > 45)) {
			healthBar.sprite = health50;
		}
		if ((health <= 45) && (health > 40)) {
			healthBar.sprite = health45;
		}
		if ((health <= 40) && (health > 35)) {
			healthBar.sprite = health40;
		}
		if ((health <= 35) && (health > 30)) {
			healthBar.sprite = health35;
		}
		if ((health <= 30) && (health > 25)) {
			healthBar.sprite = health30;
		}
		if ((health <= 25) && (health > 20)) {
			healthBar.sprite = health25;
		}
		if ((health <= 20) && (health > 15)) {
			healthBar.sprite = health20;
		}
		if ((health <= 15) && (health > 10)) {
			healthBar.sprite = health15;
		}
		if ((health <= 10) && (health > 5)) {
			healthBar.sprite = health10;
		}
		if ((health <= 5) && (health > 0)) {
			healthBar.sprite = health05;
		}
		if ((health <= 0) && (health >= 0)) {
			healthBar.sprite = health00;
		}



	}



}
