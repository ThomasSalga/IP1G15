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
	
	}



	// Update is called once per frame
	void FixedUpdate () {
	
		float health = (float)GameObject.Find ("PlayerGameObject").GetComponent<Player> ().MyDurability;
		float maxHealth = (float)GameObject.Find ("PlayerGameObject").GetComponent<Player> ().MyMaxDurability;
		float nonFinalHealth = health / maxHealth;
		float finalHealth = nonFinalHealth * 100;


		if ((finalHealth <= 100) && (finalHealth > 95)) {
			healthBar.sprite = health100;
		}
		if ((finalHealth <= 95) && (finalHealth > 90)) {
			healthBar.sprite = health95;
		}
		if ((finalHealth <= 90) && (finalHealth > 85)) {
			healthBar.sprite = health90;
		}
		if ((finalHealth <= 85) && (finalHealth > 80)) {
			healthBar.sprite = health85;
		}
		if ((finalHealth <= 80) && (finalHealth > 75)) {
			healthBar.sprite = health80;
		}
		if ((finalHealth <= 75) && (finalHealth > 70)) {
			healthBar.sprite = health75;
		}
		if ((finalHealth <= 70) && (finalHealth > 65)) {
			healthBar.sprite = health70;
		}
		if ((finalHealth <= 65) && (finalHealth > 60)) {
			healthBar.sprite = health65;
		}
		if ((finalHealth <= 60) && (finalHealth > 55)) {
			healthBar.sprite = health60;
		}
		if ((finalHealth <= 55) && (finalHealth > 50)) {
			healthBar.sprite = health55;
		}
		if ((finalHealth <= 50) && (finalHealth > 45)) {
			healthBar.sprite = health50;
		}
		if ((finalHealth <= 45) && (finalHealth > 40)) {
			healthBar.sprite = health45;
		}
		if ((finalHealth <= 40) && (finalHealth > 35)) {
			healthBar.sprite = health40;
		}
		if ((finalHealth <= 35) && (finalHealth > 30)) {
			healthBar.sprite = health35;
		}
		if ((finalHealth <= 30) && (finalHealth > 25)) {
			healthBar.sprite = health30;
		}
		if ((finalHealth <= 25) && (finalHealth > 20)) {
			healthBar.sprite = health25;
		}
		if ((finalHealth <= 20) && (finalHealth > 15)) {
			healthBar.sprite = health20;
		}
		if ((finalHealth <= 15) && (finalHealth > 10)) {
			healthBar.sprite = health15;
		}
		if ((finalHealth <= 10) && (finalHealth > 5)) {
			healthBar.sprite = health10;
		}
		if ((finalHealth <= 5) && (finalHealth > 0)) {
			healthBar.sprite = health05;
		}
		if ((finalHealth <= 0) && (finalHealth >= 0)) {
			healthBar.sprite = health00;
		}



	}



}
